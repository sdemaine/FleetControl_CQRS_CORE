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
using System.ComponentModel.DataAnnotations;
using System;

namespace FleetControl.Application.Commands.UpdateCustomer
{
    public class UpdateFleetCustomerCommand : IRequest
    {
        private readonly IFleetControlDbContext _context;

        public int Id { get; }

        public JsonPatchDocument PatchDoc { get; }

        public Customer Customer { get; }

        public UpdateFleetCustomerCommand(int id, JsonPatchDocument patchDoc, IFleetControlDbContext context)
        {
            Id = id;
            PatchDoc = patchDoc;
            _context = context;

            Customer = _context.Customer.FirstOrDefault(x => x.Id == id);
            if (Customer == null) throw new Exception("Customer not found");

            PatchDoc.ApplyTo(Customer);
            
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
                _context.Customer.Update(request.Customer);
                await _context.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
}
