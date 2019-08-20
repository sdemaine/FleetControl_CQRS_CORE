using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using Northwind.Domain.Entities;

namespace FleetControl.Application.Commands.DeleteProduct
{
    public class DeleteFleetProductCommandHandler : IRequestHandler<DeleteFleetProductCommand>
    {
        private readonly INorthwindDbContext _context;

        public DeleteFleetProductCommandHandler(INorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteFleetProductCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Products.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product), request.Id);
            }

            var hasOrders = _context.OrderDetails.Any(od => od.ProductId == entity.ProductId);
            if (hasOrders)
            {
                // TODO: Add functional test for this behaviour.
                throw new DeleteFailureException(nameof(Product), request.Id, "There are existing orders associated with this product.");
            }

            _context.Products.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
