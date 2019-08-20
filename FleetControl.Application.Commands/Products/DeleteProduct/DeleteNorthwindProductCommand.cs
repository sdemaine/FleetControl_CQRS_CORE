using MediatR;

namespace FleetControl.Application.Commands.DeleteProduct
{
    public class DeleteFleetProductCommand : IRequest
    {
        public int Id { get; set; }
    }
}
