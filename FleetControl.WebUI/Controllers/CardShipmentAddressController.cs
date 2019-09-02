using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using FleetControl.Application.Queries;
using FleetControl.Application.Queries.CardShipmentAddress;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/CardShipmentAddress")]
    public class CardShipmentAddressController : BaseController
    {
        [HttpGet]
        [Route("DxDatasource")]
        public async Task<LoadResult> Drivers(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load<GetCardShipmentAddressQueryable_Dto>(await Mediator.Send(new GetCardShipmentAddressQueryable_Query(queryRequestModel)), loadOptions);
            return response;
        }
    }
}