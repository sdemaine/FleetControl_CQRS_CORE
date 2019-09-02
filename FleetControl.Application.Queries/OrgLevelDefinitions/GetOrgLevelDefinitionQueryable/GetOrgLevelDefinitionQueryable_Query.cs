using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.OrgLevelDefinitions
{
    public class GetOrgLevelDefinitionsQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetOrgLevelDefinitionsQueryable_Dto>>, IHaveCustomMapping
    {
        public GetOrgLevelDefinitionsQueryable_Query()
        {

        }

        public GetOrgLevelDefinitionsQueryable_Query(QueryRequestModel queryRequestModel, IMapper mapper)
        {
            mapper.Map(queryRequestModel, this);
        }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<QueryRequestModel, GetOrgLevelDefinitionsQueryable_Query>();
        }
    }
}
