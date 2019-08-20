using FleetControl.Application.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/FleetCustomers")]
    public class FleetCustomersController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetFleetCustomersList_ViewModel>> GetAll([FromQuery] QueryRequestModel queryRequest)
        {
            return Ok(await Mediator.Send(new GetFleetCustomersList_Query(queryRequest)));
        }

        [HttpGet("{baid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetFleetCustomerDetail_Model>> Get(int baid)
        {
            return Ok(await Mediator.Send(new GetFleetCustomer_Query(baid)));
        }
    }
}