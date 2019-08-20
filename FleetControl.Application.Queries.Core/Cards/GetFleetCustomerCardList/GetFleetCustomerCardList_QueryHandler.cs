using AutoMapper;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries.Cards;
using FleetControl.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetCustomerCardList_QueryHandler : IRequestHandler<GetFleetCustomerCardListQuery, GetFleetCustomerCardList_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCustomerCardList_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetCustomerCardList_ViewModel> Handle(GetFleetCustomerCardListQuery request, CancellationToken cancellationToken)
        {
            var sortByValue = (request.QueryRequest.SortBy ?? "THEIRCARDNUMBER").ToUpper();
            var sortByDirection = (request.QueryRequest.SortDirection ?? "ASC").ToUpper();
            var skip = request.QueryRequest.Skip;
            var take = request.QueryRequest.Take;
            var searchQuery = request.QueryRequest.SearchQuery;

            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Id == request.CustomerId);

            if (customer == null) return null;

            IQueryable<Card> CardQuery = _context.Card.Include(x => x.Vehicle).Include(x => x.Driver).Where(x => x.CustomerId == customer.Id).AsQueryable();



            if (searchQuery != null)
            {
                CardQuery = CardQuery.Where(
                    x => x.Vehicle.VehicleDescription.Contains(searchQuery) || x.Vehicle.TheirVehicleNumber.Contains(searchQuery)
                );
            }



            if (take != 0)
            {
                CardQuery = CardQuery.Skip(skip).Take(take);
            }

            switch (sortByValue)
            {
                case "THEIRCARDNUMBER":
                    CardQuery = sortByDirection == "DESC" ?
                        CardQuery.OrderByDescending(x => x.TheirCardNumber)
                        : CardQuery.OrderBy(x => x.TheirCardNumber);

                    break;


                default:

                    break;
            }

            var Cards = await CardQuery.ToListAsync();

            return new GetFleetCustomerCardList_ViewModel(Cards.Count, "previousPage", "nextPage", _mapper.Map<IEnumerable<GetFleetCustomerCardList_Dto>>(Cards));
        }
    }
}
