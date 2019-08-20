using System.Threading;
using System.Threading.Tasks;
using FleetControl.Application.Interfaces;
using MediatR;
using FleetControl.Domain;
using AutoMapper;
using FleetControl.Application.Commands.CreateCustomer;

namespace FleetControl.Application.Commands.Customers.CreateCustomer
{
    public class CreateFleetCustomer_Command : IRequest
    {
        public CreateFleetCustomer_Dto Customer { get; }

        public CreateFleetCustomer_Command(CreateFleetCustomer_Dto customer)
        {
            Customer = customer;
        }
        public class Handler : IRequestHandler<CreateFleetCustomer_Command, Unit>
        {
            private readonly IFleetControlDbContext _context;
            private readonly IMediator _mediator;
            private readonly IMapper _mapper;

            public Handler(IFleetControlDbContext context, IMediator mediator, IMapper mapper)
            {
                _context = context;
                _mediator = mediator;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(CreateFleetCustomer_Command request, CancellationToken cancellationToken)
            {
                var entity = _mapper.Map<Customer>(request.Customer);

                _context.Customer.Add(entity);
                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new FleetCustomerCreated { Id = entity.Id }, cancellationToken);

                return Unit.Value;
            }
        }
    }
}
