using System.Threading;
using System.Threading.Tasks;
using MediatR;
using FleetControl.Application.Interfaces;
using Northwind.Domain.Entities;

namespace FleetControl.Application.Commands.CreateProduct
{
    public class CreateFleetProductCommandHandler : IRequestHandler<CreateFleetProductCommand, int>
    {
        private readonly INorthwindDbContext _context;

        public CreateFleetProductCommandHandler(INorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateFleetProductCommand request, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                ProductName = request.ProductName,
                CategoryId = request.CategoryId,
                SupplierId = request.SupplierId,
                UnitPrice = request.UnitPrice,
                Discontinued = request.Discontinued
            };

            _context.Products.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.ProductId;
        }
    }
}
