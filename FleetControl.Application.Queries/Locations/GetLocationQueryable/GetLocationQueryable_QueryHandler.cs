using AutoMapper;
using FleetControl.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Locations.GetLocationQueryable
{
    public class GetLocationQueryable_QueryHandler : IRequestHandler<GetLocationQueryable_Query, IEnumerable<GetLocationQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetLocationQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<IEnumerable<GetLocationQueryable_Dto>> Handle(GetLocationQueryable_Query request, CancellationToken cancellationToken)
        {
            var locationsQuery = _context.Location.Include(x => x.LocationPricingLocationGroups).AsQueryable();

            if (request.QueryRequestModel.ActiveOnly)
            {
                locationsQuery = locationsQuery.Where(x => x.Active == true);
            }

            if (request.QueryRequestModel.SearchQuery != null && request.QueryRequestModel.SearchQuery != string.Empty)
            {
                locationsQuery = locationsQuery.Where(x => x.Name.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()));
            }

            var locations = locationsQuery.AsEnumerable();
            

            return Task.Run(() =>  _mapper.Map<IEnumerable<GetLocationQueryable_Dto>>(locations.ToList()));
        }
    }
}