using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using FleetControl.Application.Queries;
using FleetControl.Application.Queries.Cards;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/FleetCards")]
    public class FleetCardsController : BaseController
    {
        [HttpGet]
        [Route("DxGrid")]
        public async Task<LoadResult> Cards(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load<GetFleetCardQueryable_Dto>(await Mediator.Send(new GetFleetCardQueryable_Query(queryRequestModel)), loadOptions);
            return response;
        }
    }
}