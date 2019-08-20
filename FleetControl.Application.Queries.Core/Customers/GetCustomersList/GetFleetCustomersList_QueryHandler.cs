using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetControl.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomersList_QueryHandler : IRequestHandler<GetFleetCustomersList_Query, GetFleetCustomersList_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCustomersList_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetCustomersList_ViewModel> Handle(GetFleetCustomersList_Query request, CancellationToken cancellationToken)
        {
            var getCustomersQuery = _context.Customer.AsQueryable();
            var sortByValue = (request.QueryRequest.SortBy ?? "CUSTOMERNAME").ToUpper();
            var sortByDirection = (request.QueryRequest.SortDirection ?? "ASC").ToUpper();
            var skip = request.QueryRequest.Skip;
            var take = request.QueryRequest.Take;
            var searchQuery = request.QueryRequest.SearchQuery;

            if (searchQuery != null)
            {
                getCustomersQuery = getCustomersQuery.Where(x => x.CustomerName.Contains(searchQuery) || x.Address1.Contains(searchQuery) || x.Contact.Contains(searchQuery) || x.Telephone.Contains(searchQuery));
            }
            


            if (take != 0)
            {
                getCustomersQuery = getCustomersQuery.Skip(skip).Take(take);
            }

            switch (sortByValue)
            {
                case "CUSTOMERNAME":
                    getCustomersQuery = sortByDirection == "DESC" ?
                        getCustomersQuery.OrderByDescending(x => x.CustomerName)
                        : getCustomersQuery.OrderBy(x => x.CustomerName);

                    break;

                case "ADDRESS":
                    getCustomersQuery = sortByDirection == "DESC" ?
                        getCustomersQuery.OrderByDescending(x => x.Address1)
                        : getCustomersQuery.OrderBy(x => x.Address1);

                    break;

                case "CONTACT":
                    getCustomersQuery = sortByDirection == "DESC" ?
                        getCustomersQuery.OrderByDescending(x => x.Contact)
                        : getCustomersQuery.OrderBy(x => x.Contact);

                    break;


                default:

                    break;
            }



            var customers = await getCustomersQuery.ToListAsync();


            return new GetFleetCustomersList_ViewModel(customers.Count, "previousPage", "nextPage", _mapper.Map<IEnumerable<GetFleetCustomerList_Dto>>(customers));
        }
    }
}
