using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.OrgLevelDefinitions
{
    public class GetOrgLevelDefinitionsQueryable_QueryHandler : IRequestHandler<GetOrgLevelDefinitionsQueryable_Query, IEnumerable<GetOrgLevelDefinitionsQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetOrgLevelDefinitionsQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetOrgLevelDefinitionsQueryable_Dto>> Handle(GetOrgLevelDefinitionsQueryable_Query request, CancellationToken cancellationToken)
        {
            var orgLevelDefinitionQuery = _context.OrgLevelDefinition.AsQueryable();

            if (request.CustomerId != 0)
            {
                orgLevelDefinitionQuery = orgLevelDefinitionQuery.Where(x => x.CustomerId == request.CustomerId);
            }

            var orgLevelDefinitions = await orgLevelDefinitionQuery.ToListAsync();
            return _mapper.Map<IEnumerable<GetOrgLevelDefinitionsQueryable_Dto>>(orgLevelDefinitions);
        }
    }
}
