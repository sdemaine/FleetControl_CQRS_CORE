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

namespace FleetControl.Application.Queries.Cards
{
    public class GetFleetCardQueryable_QueryHandler : IRequestHandler<GetFleetCardQueryable_Query, IEnumerable<GetFleetCardQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCardQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetFleetCardQueryable_Dto>> Handle(GetFleetCardQueryable_Query request, CancellationToken cancellationToken)
        {
            var CardsQuery = _context.Card.Include(x => x.Vehicle).Include(x => x.Driver).AsQueryable();

            if (request.ActiveOnly)
            {
                CardsQuery = CardsQuery.Where(x => x.Status == Core.StatusMode.Active);
            }

            if (request.SearchQuery != null && request.QueryRequestModel.SearchQuery != string.Empty)
            {
                //CardsQuery = CardsQuery.Where(x => x.LastName.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()) || x.FirstName.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()));
            }


            var Cards = CardsQuery.AsEnumerable();

            return _mapper.Map<IEnumerable<GetFleetCardQueryable_Dto>>(Cards);
        }
    }
}
