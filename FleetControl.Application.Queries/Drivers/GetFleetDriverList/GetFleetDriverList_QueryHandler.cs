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

namespace FleetControl.Application.Queries.Drivers.GetFleetDriverList
{
    public class GetFleetDriverList_QueryHandler : IRequestHandler<GetFleetDriverListQuery, GetFleetDriverList_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetDriverList_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetDriverList_ViewModel> Handle(GetFleetDriverListQuery request, CancellationToken cancellationToken)
        {
            var sortByValue = (request.QueryRequest.SortBy ?? "LASTNAME").ToUpper();
            var sortByDirection = (request.QueryRequest.SortDirection ?? "ASC").ToUpper();
            var skip = request.QueryRequest.Skip;
            var take = request.QueryRequest.Take;
            var searchQuery = request.QueryRequest.SearchQuery;
            var activeOnly = request.QueryRequest.ActiveOnly;
            var baid = request.QueryRequest.Baid;

            IQueryable<Driver> driverQuery = _context.Driver;

            if (baid != 0)
            {
                var customer = await _context.Customer.FirstOrDefaultAsync(x => x.BAID == baid);
                if (customer != null)
                {
                    driverQuery = driverQuery.Where(x => x.CustomerId == customer.Id);
                } else
                {
                    driverQuery = driverQuery.Where(x => x.Id == 0);
                }
            }

            if (activeOnly)
            {
                driverQuery = driverQuery.Where(x => x.Status == Core.StatusMode.Active);
            }

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

            return new GetFleetDriverList_ViewModel(drivers.Count, "previousPage", "nextPage", _mapper.Map<IEnumerable<GetFleetDriverList_Dto>>(drivers));
        }
    }
}
