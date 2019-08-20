using System.Threading;
using System.Threading.Tasks;
using FleetControl.Application.Interfaces;
using MediatR;
using FleetControl.Domain;

namespace FleetControl.Application.Commands.CreateCustomer
{
    public class CreateFleetCustomerCommand : IRequest
    {
        public int Id { get; set; }


        public class Handler : IRequestHandler<CreateFleetCustomerCommand, Unit>
        {
            private readonly IFleetControlDbContext _context;
            private readonly IMediator _mediator;

            public Handler(IFleetControlDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(CreateFleetCustomerCommand request, CancellationToken cancellationToken)
            {
                var entity = new Customer
                {
                    Id = request.Id
                };

                //_context.Customer.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new FleetCustomerCreated { Id = entity.Id }, cancellationToken);

                return Unit.Value;
            }
        }
    }
}
