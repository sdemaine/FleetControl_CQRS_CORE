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

namespace FleetControl.Application.Queries.BusinessHours
{
    public class GetBusinessHoursQueryable_QueryHandler : IRequestHandler<GetBusinessHoursQueryable_Query, IEnumerable<GetBusinessHoursQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetBusinessHoursQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetBusinessHoursQueryable_Dto>> Handle(GetBusinessHoursQueryable_Query request, CancellationToken cancellationToken)
        {
            var businessHoursQuery = _context.BusinessHours.AsQueryable();

            if (request.QueryRequestModel.CustomerId != 0)
            {
                businessHoursQuery = businessHoursQuery.Where(x => x.CustomerId == request.QueryRequestModel.CustomerId);
            }

            if (request.QueryRequestModel.SearchQuery != null && request.QueryRequestModel.SearchQuery != string.Empty)
            {
                // businessHoursQuery = businessHoursQuery.Where(x => x.LastName.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()) || x.FirstName.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()));
            }


            var businessHours = await businessHoursQuery.ToListAsync();

            return _mapper.Map<IEnumerable<GetBusinessHoursQueryable_Dto>>(businessHours);
        }
    }
}
