using FleetControl.Application.Queries.Drivers;
using MediatR;

namespace FleetControl.Application.Queries.Drivers.GetFleetDriverList
{
    public class GetFleetDriverListQuery : IRequest<GetFleetDriverList_ViewModel>
    {
        public QueryRequestModel QueryRequest { get; }

        public GetFleetDriverListQuery(QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
        }
    }
}
