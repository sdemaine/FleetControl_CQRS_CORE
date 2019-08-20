using MediatR;
using Microsoft.EntityFrameworkCore;
using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Commands.UpdateCustomer
{
    public class UpdateFleetCustomerCommand : IRequest
    {
        public int Id { get; set; }
        

        public class Handler : IRequestHandler<UpdateFleetCustomerCommand, Unit>
        {
            private readonly IFleetControlDbContext _context;

            public Handler(IFleetControlDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateFleetCustomerCommand request, CancellationToken cancellationToken)
            {
                //var entity = await _context.Customer
                //    .SingleOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

                //if (entity == null)
                //{
                //    throw new NotFoundException(nameof(Customer), request.Id);
                //}

                //entity.Address = request.Address;
                //entity.City = request.City;
                //entity.CompanyName = request.CompanyName;
                //entity.ContactName = request.ContactName;
                //entity.ContactTitle = request.ContactTitle;
                //entity.Country = request.Country;
                //entity.Fax = request.Fax;
                //entity.Phone = request.Phone;
                //entity.PostalCode = request.PostalCode;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
