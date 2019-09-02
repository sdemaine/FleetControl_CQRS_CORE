
using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using FleetControl.Application.Commands.Customers.CreateCustomer;
using FleetControl.Application.Commands.Customers.UpdateCustomer;
using FleetControl.Application.Commands.UpdateCustomer;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries;
using FleetControl.Application.Queries.BusinessHours;
using FleetControl.Application.Queries.Cards;
using FleetControl.Application.Queries.CardShipmentAddress;
using FleetControl.Application.Queries.Customers;
using FleetControl.Application.Queries.Drivers;
using FleetControl.Application.Queries.Locations.GetLocationQueryable;
using FleetControl.Application.Queries.OrgLevelDefinitions;
using FleetControl.Application.Queries.Transactions;
using FleetControl.Application.Queries.Vehicles;
using FleetControl.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/DxDatasource")]
    public class DxDatasourceController : BaseController
    {
        private readonly IMapper _mapper;

        public DxDatasourceController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpGet]
        [Route("Customers")]
        public async Task<LoadResult> Customers(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetCustomerQueryable_Query(queryRequestModel, _mapper)), loadOptions);
            return response;
        }

        [HttpGet]
        [Route("Cards")]
        public async Task<LoadResult> Cards(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetFleetCardQueryable_Query(queryRequestModel)), loadOptions);
            return response;
        }

        [HttpGet]
        [Route("Vehicles")]
        public async Task<LoadResult> Vehicles(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetVehicleQueryable_Query(queryRequestModel, _mapper)), loadOptions);
            return response;
        }

        [HttpGet]
        [Route("Drivers")]
        public async Task<LoadResult> Drivers(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetFleetDriverQueryable_Query(queryRequestModel, _mapper)), loadOptions);
            return response;
        }

        

        [HttpGet]
        [Route("CardShipmentAddresses")]
        public async Task<LoadResult> CardShipmentAddresses(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetCardShipmentAddressQueryable_Query(queryRequestModel)), loadOptions);
            return response;
        }

        [HttpGet]
        [Route("CustomerCardTypes")]
        public async Task<LoadResult> CustomerCardTypes(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetCustomerCardCategoryQueryable_Query(queryRequestModel)), loadOptions);
            return response;
        }

        [HttpGet]
        [Route("Locations")]
        public async Task<LoadResult> Locations(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetLocationQueryable_Query(queryRequestModel)), loadOptions);
            return response;
        }

        [HttpGet]
        [Route("OrgLevelDefinitions")]
        public async Task<LoadResult> OrgLevelDefinitions(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetOrgLevelDefinitionsQueryable_Query(queryRequestModel, _mapper)), loadOptions);
            return response;
        }

        [HttpGet]
        [Route("BusinessHours")]
        public async Task<LoadResult> BusinessHours(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetBusinessHoursQueryable_Query(queryRequestModel)), loadOptions);
            return response;
        }

        [HttpGet]
        [Route("Transactions")]
        public async Task<LoadResult> Transactions(DataSourceLoadOptions loadOptions, [FromQuery] QueryRequestModel queryRequestModel)
        {
            var response = DataSourceLoader.Load(await Mediator.Send(new GetTransactionsQueryable_Query(queryRequestModel, _mapper)), loadOptions);
            return response;
        }
    }
}
