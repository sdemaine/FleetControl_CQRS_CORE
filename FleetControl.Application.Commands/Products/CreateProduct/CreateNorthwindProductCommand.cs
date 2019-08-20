using MediatR;

namespace FleetControl.Application.Commands.CreateProduct
{
    public class CreateFleetProductCommand : IRequest<int>
    {
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? SupplierId { get; set; }

        public int? CategoryId { get; set; }

        public bool Discontinued { get; set; }
    }
}
