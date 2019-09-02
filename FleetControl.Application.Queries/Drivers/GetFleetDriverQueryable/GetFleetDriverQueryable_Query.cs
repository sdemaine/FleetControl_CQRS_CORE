using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriverQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetFleetDriverQueryable_Dto>>, IHaveCustomMapping
    {

        public GetFleetDriverQueryable_Query()
        {

        }

        public GetFleetDriverQueryable_Query(QueryRequestModel queryRequestModel, IMapper mapper)
        {
            mapper.Map(queryRequestModel, this);
        }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<QueryRequestModel, GetFleetDriverQueryable_Query>();
        }
    }
}
