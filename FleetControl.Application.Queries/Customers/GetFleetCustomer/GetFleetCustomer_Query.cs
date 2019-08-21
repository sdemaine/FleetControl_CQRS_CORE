using MediatR;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomer_Query : IRequest<GetFleetCustomer_ViewModel>
    {
        public int CustomerId { get; }

        public GetFleetCustomer_Query(int customerId)
        {
            CustomerId = customerId;
        }
    }
}
