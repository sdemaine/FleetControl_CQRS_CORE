using FleetControl.Application.Queries;
using FleetControl.Application.Queries.Customers.GetFleetCustomer;
using FleetControl.Application.Queries.Drivers;
using FleetControl.Application.Queries.Drivers.GetFleetDriverList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/FleetDrivers")]
    public class FleetDriversController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<GetFleetCustomerDriverList_ViewModel>>> GetAll([FromQuery] QueryRequestModel queryRequest)
        {
            return Ok(await Mediator.Send(new GetFleetDriverListQuery(queryRequest)));
        }
    }
}