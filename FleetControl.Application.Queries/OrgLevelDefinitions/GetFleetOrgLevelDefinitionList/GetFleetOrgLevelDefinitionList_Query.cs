using FleetControl.Application.Queries.OrgLevelDefinitions;
using MediatR;

namespace FleetControl.Application.Queries.OrgLevelDefinitions.GetFleetOrgLevelDefinitionList
{
    public class GetFleetOrgLevelDefinitionList_Query : IRequest<GetFleetOrgLevelDefinitionList_ViewModel>
    {
        public QueryRequestModel QueryRequest { get; }

        public GetFleetOrgLevelDefinitionList_Query(QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
        }
    }
}
