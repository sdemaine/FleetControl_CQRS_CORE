using FleetControl.Application.Commands.Customers.CreateCustomer;
using FleetControl.Application.Commands.Customers.UpdateCustomer;
using FleetControl.Application.Commands.UpdateCustomer;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<GetFleetCustomerDetail_Model>> CreateCustomer(CreateFleetCustomer_Dto customer)
        {
            await Mediator.Send(new CreateFleetCustomer_Command(customer));
            return Ok();
        }

        [HttpPatch]
        [Route("{customerId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetFleetCustomerDetail_Model>> UpdateCustomer(int customerId, [FromBody] JsonPatchDocument patchDoc)
        {
            await Mediator.Send(new UpdateFleetCustomerCommand(customerId, patchDoc, _context));
            return Ok();
        }
    }
}