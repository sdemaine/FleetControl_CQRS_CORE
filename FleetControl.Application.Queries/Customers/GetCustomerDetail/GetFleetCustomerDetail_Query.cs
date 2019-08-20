using MediatR;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerDetail_Query : IRequest<GetFleetCustomerDetail_Model>
    {
        public string Id { get; set; }
    }
}
