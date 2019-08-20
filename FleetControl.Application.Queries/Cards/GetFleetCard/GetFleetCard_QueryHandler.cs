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

namespace FleetControl.Application.Queries.Cards
{
    public class GetFleetCard_QueryHandler
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCard_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetCard_ViewModel> Handle(GetFleetCard_Query request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Id == request.CardId);

            var Cards = new List<Card>();

            if (customer != null)
            {
                Cards = await _context.Card.Where(x => x.CustomerId == customer.Id).ToListAsync();
            }

            return new GetFleetCard_ViewModel
            {
                Card = _mapper.Map<GetFleetCard_ViewDto>(Cards)
            };
        }
    }
}
