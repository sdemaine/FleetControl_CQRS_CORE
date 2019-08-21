using MediatR;
using Microsoft.EntityFrameworkCore;
using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using System.Threading;
using System.Threading.Tasks;
using FleetControl.Application.Commands.Customers.UpdateCustomer;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

namespace FleetControl.Application.Commands.UpdateCustomer
{
    public class UpdateFleetCustomerCommand : IRequest
    {
        public int Id { get; }

        public JsonPatchDocument PatchDoc { get; }

        public UpdateFleetCustomerCommand(int id, JsonPatchDocument patchDoc)
        {
            Id = id;
            PatchDoc = patchDoc;
        }


        public class Handler : IRequestHandler<UpdateFleetCustomerCommand, Unit>
        {
            private readonly IFleetControlDbContext _context;
            private readonly IMapper _mapper;

            public Handler(IFleetControlDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(UpdateFleetCustomerCommand request, CancellationToken cancellationToken)
            {
                var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (customer == null)
                {
                    throw new NotFoundException("Customer", request.Id);
                }

                request.PatchDoc.ApplyTo(customer);
                _context.Customer.Update(customer);
                

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

                return Unit.Value; // Unit.Value;
            }
        }
    }
}
