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
using Newtonsoft.Json;

namespace FleetControl.Application.Commands.UpdateCustomer
{
    public class UpdateFleetDriver_Command : IRequest
    {
        private readonly IFleetControlDbContext _context;

        public int Id { get; }
        public string DriverUpdates { get; }

        public Driver Driver { get; }

        public UpdateFleetDriver_Command(int id, string driverUpdates, IFleetControlDbContext context, IMapper mapper)
        {
            Id = id;
            _context = context;
            DriverUpdates = driverUpdates;

            

            Driver = _context.Driver.FirstOrDefault(x => x.Id == id);
            if (Driver == null) throw new Exception("Driver not found");

            UpdateFleetDriver_Dto UpdateFleetDriver_Dto = mapper.Map<Driver, UpdateFleetDriver_Dto>(Driver);

            JsonConvert.PopulateObject(driverUpdates, UpdateFleetDriver_Dto);
            mapper.Map(UpdateFleetDriver_Dto, Driver);
        }


        public class Handler : IRequestHandler<UpdateFleetDriver_Command, Unit>
        {
            private readonly IFleetControlDbContext _context;
            private readonly IMapper _mapper;

            public Handler(IFleetControlDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(UpdateFleetDriver_Command request, CancellationToken cancellationToken)
            {
                _context.Driver.Update(request.Driver);
                await _context.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
}
