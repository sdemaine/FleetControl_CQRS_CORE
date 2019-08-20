using AutoMapper;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriver_QueryHandler
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetDriver_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetDriver_ViewModel> Handle(GetFleetDriver_Query request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Id == request.DriverId);

            var drivers = new List<Driver>();

            if (customer != null)
            {
                drivers = await _context.Driver.Where(x => x.CustomerId == customer.Id).ToListAsync();
            }

            return new GetFleetDriver_ViewModel
            {
                Driver = _mapper.Map<GetFleetDriver_ViewDto>(drivers)
            };
        }
    }
}
