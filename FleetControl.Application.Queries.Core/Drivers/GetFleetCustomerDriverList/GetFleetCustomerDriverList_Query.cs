using FleetControl.Application.Queries.Drivers;
using MediatR;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetCustomerDriverListQuery : IRequest<GetFleetCustomerDriverList_ViewModel>
    {
        public QueryRequestModel QueryRequest { get; }
        public int CustomerId { get; }

        public GetFleetCustomerDriverListQuery(int customerId, QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
            CustomerId = customerId;
        }
    }
}
