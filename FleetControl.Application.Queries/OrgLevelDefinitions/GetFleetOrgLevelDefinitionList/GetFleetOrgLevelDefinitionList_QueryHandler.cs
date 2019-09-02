using AutoMapper;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries.OrgLevelDefinitions;
using FleetControl.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.OrgLevelDefinitions.GetFleetOrgLevelDefinitionList
{
    public class GetFleetOrgLevelDefinitionList_QueryHandler : IRequestHandler<GetFleetOrgLevelDefinitionList_Query, GetFleetOrgLevelDefinitionList_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetOrgLevelDefinitionList_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetOrgLevelDefinitionList_ViewModel> Handle(GetFleetOrgLevelDefinitionList_Query request, CancellationToken cancellationToken)
        {
            var sortByValue = (request.QueryRequest.SortBy ?? "LASTNAME").ToUpper();
            var sortByDirection = (request.QueryRequest.SortDirection ?? "ASC").ToUpper();
            var skip = request.QueryRequest.Skip;
            var take = request.QueryRequest.Take;
            var searchQuery = request.QueryRequest.SearchQuery;
            var activeOnly = request.QueryRequest.ActiveOnly;
            var baid = request.QueryRequest.Baid;
            var customerId = request.QueryRequest.CustomerId;

            IQueryable<OrgLevelDefinition> OrgLevelDefinitionQuery = _context.OrgLevelDefinition;

            if (customerId != 0)
            {
                OrgLevelDefinitionQuery = OrgLevelDefinitionQuery.Where(x => x.CustomerId == customerId);
            }

            if (activeOnly)
            {
                OrgLevelDefinitionQuery = OrgLevelDefinitionQuery.Where(x => x.Active == true);
            }

            //if (searchQuery != null)
            //{
            //    OrgLevelDefinitionQuery = OrgLevelDefinitionQuery.Where(x => x.FirstName.Contains(searchQuery) || x.LastName.Contains(searchQuery) || x.TheirEmployeeNumber.Contains(searchQuery));
            //}

            if (take != 0)
            {
                OrgLevelDefinitionQuery = OrgLevelDefinitionQuery.Skip(skip).Take(take);
            }

            var OrgLevelDefinitions = await OrgLevelDefinitionQuery.ToListAsync();

            return new GetFleetOrgLevelDefinitionList_ViewModel(OrgLevelDefinitions.Count, "previousPage", "nextPage", _mapper.Map<IEnumerable<GetFleetOrgLevelDefinitionList_Dto>>(OrgLevelDefinitions));
        }
    }
}
