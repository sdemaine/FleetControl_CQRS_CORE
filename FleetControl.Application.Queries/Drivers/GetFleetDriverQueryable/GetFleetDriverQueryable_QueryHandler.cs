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

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriverQueryable_QueryHandler : IRequestHandler<GetFleetDriverQueryable_Query, IEnumerable<GetFleetDriverQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetDriverQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetFleetDriverQueryable_Dto>> Handle(GetFleetDriverQueryable_Query request, CancellationToken cancellationToken)
        {
            var driversQuery = _context.Driver.AsQueryable();

            if (request.CustomerId != 0)
            {
                driversQuery = driversQuery.Where(x => x.CustomerId == request.CustomerId);
            }

            if (request.ActiveOnly)
            {
                driversQuery = driversQuery.Where(x => x.Status == Core.StatusMode.Active);
            }

            if (request.SearchQuery != null && request.SearchQuery != string.Empty)
            {
                driversQuery = driversQuery.Where(x => x.LastName.ToLower().Contains(request.SearchQuery.ToLower()) || x.FirstName.ToLower().Contains(request.SearchQuery.ToLower()));
            }


            var drivers = await driversQuery.ToListAsync();

            return _mapper.Map<IEnumerable<GetFleetDriverQueryable_Dto>>(drivers);
        }
    }
}
