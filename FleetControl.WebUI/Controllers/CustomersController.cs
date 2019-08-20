using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Application.Commands.CreateCustomer;
using Northwind.Application.Commands.DeleteCustomer;
using Northwind.Application.Commands.UpdateCustomer;
using Northwind.Application.Queries.GetCustomerDetail;
using Northwind.Application.Queries.GetCustomerList;
using Northwind.Application.Queries.Orders.GetCustomerOrders;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/Customers")]
    public class CustomersController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<NorthwindCustomersListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetNorthwindCustomersListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<NorthwindCustomerDetailModel>> Get(string id)
        {
            return Ok(await Mediator.Send(new GetNorthwindCustomerDetailQuery { Id = id }));
        }

        [HttpGet]
        [Route("{customerId}/orders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<NorthwindCustomerOrderListViewModel>> GetOrders(string customerId)
        {
            return Ok(await Mediator.Send(new GetNorthwindCustomerOrdersQuery { CustomerId = customerId }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody]CreateNorthwindCustomerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromBody]UpdateNorthwindCustomerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id)
        {
            await Mediator.Send(new DeleteNorthwindCustomerCommand { CustomerId = id });

            return NoContent();
        }
    }
}