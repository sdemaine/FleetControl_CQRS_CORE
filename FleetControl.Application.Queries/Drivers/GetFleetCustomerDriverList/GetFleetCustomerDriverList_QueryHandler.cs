using AutoMapper;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries.Drivers;
using FleetControl.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetCustomerDriverList_QueryHandler : IRequestHandler<GetFleetCustomerDriverListQuery, GetFleetCustomerDriverList_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCustomerDriverList_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetCustomerDriverList_ViewModel> Handle(GetFleetCustomerDriverListQuery request, CancellationToken cancellationToken)
        {
            var sortByValue = (request.QueryRequest.SortBy ?? "LASTNAME").ToUpper();
            var sortByDirection = (request.QueryRequest.SortDirection ?? "ASC").ToUpper();
            var skip = request.QueryRequest.Skip;
            var take = request.QueryRequest.Take;
            var searchQuery = request.QueryRequest.SearchQuery;

            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Id == request.CustomerId);

            if (customer == null) return null;

            IQueryable<Driver> driverQuery = _context.Driver.Where(x => x.CustomerId == customer.Id).AsQueryable();



            if (searchQuery != null)
            {
                driverQuery = driverQuery.Where(x => x.FirstName.Contains(searchQuery) || x.LastName.Contains(searchQuery) || x.TheirEmployeeNumber.Contains(searchQuery));
            }



            if (take != 0)
            {
                driverQuery = driverQuery.Skip(skip).Take(take);
            }

            switch (sortByValue)
            {
                case "FIRSTNAME":
                    driverQuery = sortByDirection == "DESC" ?
                        driverQuery.OrderByDescending(x => x.FirstName)
                        : driverQuery.OrderBy(x => x.FirstName);

                    break;

                case "LASTNAME":
                    driverQuery = sortByDirection == "DESC" ?
                        driverQuery.OrderByDescending(x => x.LastName)
                        : driverQuery.OrderBy(x => x.LastName);

                    break;

                case "THEIREMPLOYEENUMBER":
                    driverQuery = sortByDirection == "DESC" ?
                        driverQuery.OrderByDescending(x => x.TheirEmployeeNumber)
                        : driverQuery.OrderBy(x => x.TheirEmployeeNumber);

                    break;


                default:

                    break;
            }

            var drivers = await driverQuery.ToListAsync();

            return new GetFleetCustomerDriverList_ViewModel(drivers.Count, "previousPage", "nextPage", _mapper.Map<IEnumerable<GetFleetCustomerDriverList_ViewDto>>(drivers));
        }
    }
}
