using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using MediatR;
using System.Collections.Generic;

namespace FleetControl.Application.Queries.Vehicles
{
    public class GetVehicleQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetVehicleQueryable_Dto>>, IHaveCustomMapping
    {

        public GetVehicleQueryable_Query()
        {

        }

        public GetVehicleQueryable_Query(QueryRequestModel queryRequestModel, IMapper mapper)
        {
            mapper.Map(queryRequestModel, this);
        }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<QueryRequestModel, GetVehicleQueryable_Query>();
        }
    }
}
