using MediatR;

namespace FleetControl.Application.Commands.DeleteCustomer
{
    public class DeleteFleetCustomerCommand : IRequest
    {
        public int Id { get; set; }
    }
}
