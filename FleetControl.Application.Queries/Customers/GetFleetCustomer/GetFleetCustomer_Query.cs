using MediatR;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomer_Query : IRequest<GetFleetCustomer_ViewModel>
    {
        public int Baid { get; }

        public GetFleetCustomer_Query(int baid)
        {
            Baid = baid;
        }
    }
}
