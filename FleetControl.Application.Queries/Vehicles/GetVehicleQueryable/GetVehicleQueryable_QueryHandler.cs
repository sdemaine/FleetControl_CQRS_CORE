using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Vehicles
{
    public class GetVehicleQueryable_QueryHandler : IRequestHandler<GetVehicleQueryable_Query, IEnumerable<GetVehicleQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetVehicleQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetVehicleQueryable_Dto>> Handle(GetVehicleQueryable_Query request, CancellationToken cancellationToken)
        {
            var vehiclesQuery = _context.Vehicle.AsQueryable();

            if (request.CustomerId != 0)
            {
                vehiclesQuery = vehiclesQuery.Where(x => x.CustomerId == request.CustomerId);
            }

            if (request.ActiveOnly)
            {
                vehiclesQuery = vehiclesQuery.Where(x => x.Status == Core.StatusMode.Active);
            }

            //if (request.QueryRequestModel.SearchQuery != null && request.QueryRequestModel.SearchQuery != string.Empty)
            //{
            //    vehiclesQuery = vehiclesQuery.Where(x => x.LastName.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()) || x.FirstName.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()));
            //}


            var Vehicles = await vehiclesQuery.ToListAsync();

            return _mapper.Map<IEnumerable<GetVehicleQueryable_Dto>>(Vehicles);
        }
    }
}
