using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Commands.DeleteCustomer
{
    public class DeleteFleetCustomerCommandHandler : IRequestHandler<DeleteFleetCustomerCommand>
    {
        private readonly IFleetControlDbContext _context;

        public DeleteFleetCustomerCommandHandler(IFleetControlDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteFleetCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Customer
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Customer), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.Id);
            //if (hasOrders)
            //{
            //    // TODO: Add functional test for this behaviour.
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.Customer.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
