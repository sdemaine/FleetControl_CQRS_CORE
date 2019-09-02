using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using FleetControl.Application.Queries;
using FleetControl.Application.Queries.Drivers;
using FleetControl.Application.Queries.Locations.GetLocationQueryable;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/FleetLocations")]
    public class FleetLocationsController : BaseController
    {
        [HttpGet]
        [Route("DxGrid")]
        public async Task<LoadResult> Drivers(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load<GetLocationQueryable_Dto>(await Mediator.Send(new GetLocationQueryable_Query(queryRequestModel)), loadOptions); ;
            return response;
        }
    }
}