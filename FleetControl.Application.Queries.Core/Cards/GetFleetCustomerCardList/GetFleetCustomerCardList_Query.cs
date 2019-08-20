using FleetControl.Application.Queries.Cards;
using MediatR;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetCustomerCardListQuery : IRequest<GetFleetCustomerCardList_ViewModel>
    {
        public QueryRequestModel QueryRequest { get; }
        public int CustomerId { get; }

        public GetFleetCustomerCardListQuery(int customerId, QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
            CustomerId = customerId;
        }
    }
}
