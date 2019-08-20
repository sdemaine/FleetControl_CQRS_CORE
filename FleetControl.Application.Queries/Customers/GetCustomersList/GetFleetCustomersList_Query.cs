using MediatR;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomersList_Query : IRequest<GetFleetCustomersList_ViewModel>
    {
        public QueryRequestModel QueryRequest { get; }

        public GetFleetCustomersList_Query(QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
        }
    }
}
