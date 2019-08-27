
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using FleetControl.Application.Commands.Customers.CreateCustomer;
using FleetControl.Application.Commands.Customers.UpdateCustomer;
using FleetControl.Application.Commands.UpdateCustomer;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries;
using FleetControl.Application.Queries.Drivers;
using FleetControl.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/FleetCustomers")]
    public class FleetCustomersController : BaseController
    {
        private IFleetControlDbContext _context;

        public FleetCustomersController(IFleetControlDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("DxGrid")]
        public async Task<LoadResult> Drivers(DataSourceLoadOptions loadOptions)
        {
            var response = DataSourceLoader.Load<GetFleetDriverQueryable_ViewDto>(await Mediator.Send(new GetFleetDriverQueryable_Query() { CustomerId = 101 }), loadOptions); ;
            return response;
            //var query = _context.Driver.Where(x => x.CustomerId == 101);
            //var response = DataSourceLoader.Load(query, loadOptions);
            //response.totalCount = query.Count();

            //var result = Task<LoadResult>.Run(() => response);
            //return result;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetFleetCustomersList_ViewModel>> GetAll([FromQuery] QueryRequestModel queryRequest)
        {
            return Ok(await Mediator.Send(new GetFleetCustomersList_Query(queryRequest)));
        }

        [HttpGet("{customerId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetFleetCustomerDetail_Model>> Get(int customerId)
        {
            return Ok(await Mediator.Send(new GetFleetCustomer_Query(customerId)));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> CreateCustomer(CreateFleetCustomer_Dto customer)
        {
            return Ok(await Mediator.Send(new CreateFleetCustomer_Command(customer)));
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> UpdateCustomer(int id, [FromBody] string values)
        {
            var driver = await _context.Driver.FirstOrDefaultAsync(x => x.Id == id);
            JsonConvert.PopulateObject(values, driver);
            _context.Driver.Update(driver);
            await _context.SaveChangesAsync(new System.Threading.CancellationToken());

            return Ok();
            //return Ok(await Mediator.Send(new UpdateFleetCustomer_Command(id, customer)));
        }

        //[HttpPatch]
        //[Route("{customerId}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<GetFleetCustomerDetail_Model>> UpdateCustomer(int customerId, [FromBody] JsonPatchDocument patchDoc)
        //{
        //    await Mediator.Send(new UpdateFleetCustomerCommand(customerId, patchDoc, _context));
        //}
    }
}