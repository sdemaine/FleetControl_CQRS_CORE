using AutoMapper;
using FleetControl.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Customers
{
    public class GetFleetCustomerQueryable_QueryHandler : IRequestHandler<GetCustomerQueryable_Query, IEnumerable<GetCustomerQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCustomerQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCustomerQueryable_Dto>> Handle(GetCustomerQueryable_Query request, CancellationToken cancellationToken)
        {
            var CustomersQuery = _context.Customer.AsQueryable();

            if (request.CustomerId != 0)
            {
                CustomersQuery = CustomersQuery.Where(x => x.Id == request.CustomerId);
            }

            if (request.ActiveOnly)
            {
                //CustomersQuery = CustomersQuery.Where(x => x.Status == Core.StatusMode.Active);
            }

            if (request.SearchQuery != null && request.SearchQuery != string.Empty)
            {
                CustomersQuery = CustomersQuery.Where(x => x.CustomerName.ToLower().Contains(request.SearchQuery.ToLower()));
            }

            var Customers = await CustomersQuery.ToListAsync();

            return _mapper.Map<IEnumerable<GetCustomerQueryable_Dto>>(Customers);
        }
    }
}
