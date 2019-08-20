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

namespace FleetControl.Application.Queries.Cards.GetFleetCardList
{
    public class GetFleetCardList_QueryHandler : IRequestHandler<GetFleetCardListQuery, GetFleetCardList_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCardList_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetCardList_ViewModel> Handle(GetFleetCardListQuery request, CancellationToken cancellationToken)
        {
            var sortByValue = (request.QueryRequest.SortBy ?? "LASTNAME").ToUpper();
            var sortByDirection = (request.QueryRequest.SortDirection ?? "ASC").ToUpper();
            var skip = request.QueryRequest.Skip;
            var take = request.QueryRequest.Take;
            var searchQuery = request.QueryRequest.SearchQuery;
            var activeOnly = request.QueryRequest.ActiveOnly;
            var baid = request.QueryRequest.Baid;

            IQueryable<Card> CardQuery = _context.Card;

            if (baid != 0)
            {
                var customer = await _context.Customer.FirstOrDefaultAsync(x => x.BAID == baid);
                if (customer != null)
                {
                    CardQuery = CardQuery.Where(x => x.CustomerId == customer.Id);
                } else
                {
                    CardQuery = CardQuery.Where(x => x.Id == 0);
                }
            }

            if (activeOnly)
            {
                CardQuery = CardQuery.Where(x => x.Status == Core.StatusMode.Active);
            }

            //if (searchQuery != null)
            //{
            //    CardQuery = CardQuery.Where(x => x.FirstName.Contains(searchQuery) || x.LastName.Contains(searchQuery) || x.TheirEmployeeNumber.Contains(searchQuery));
            //}

            //if (take != 0)
            //{
            //    CardQuery = CardQuery.Skip(skip).Take(take);
            //}

            //switch (sortByValue)
            //{
            //    case "FIRSTNAME":
            //        CardQuery = sortByDirection == "DESC" ?
            //            CardQuery.OrderByDescending(x => x.FirstName)
            //            : CardQuery.OrderBy(x => x.FirstName);

            //        break;

            //    case "LASTNAME":
            //        CardQuery = sortByDirection == "DESC" ?
            //            CardQuery.OrderByDescending(x => x.LastName)
            //            : CardQuery.OrderBy(x => x.LastName);

            //        break;

            //    case "THEIREMPLOYEENUMBER":
            //        CardQuery = sortByDirection == "DESC" ?
            //            CardQuery.OrderByDescending(x => x.TheirEmployeeNumber)
            //            : CardQuery.OrderBy(x => x.TheirEmployeeNumber);

            //        break;


            //    default:

            //        break;
            //}

            var Cards = await CardQuery.ToListAsync();

            return new GetFleetCardList_ViewModel(Cards.Count, "previousPage", "nextPage", _mapper.Map<IEnumerable<GetFleetCardList_Dto>>(Cards));
        }
    }
}
