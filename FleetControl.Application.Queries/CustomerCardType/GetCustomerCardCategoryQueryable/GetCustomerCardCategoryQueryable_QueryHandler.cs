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

namespace FleetControl.Application.Queries.Drivers
{
    public class GetCustomerCardCategoryQueryable_QueryHandler : IRequestHandler<GetCustomerCardCategoryQueryable_Query, IEnumerable<GetCustomerCardCategoryQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomerCardCategoryQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCustomerCardCategoryQueryable_Dto>> Handle(GetCustomerCardCategoryQueryable_Query request, CancellationToken cancellationToken)
        {
            var customerCardCategoryQuery = _context.CustomerCardCategory.AsQueryable();

            if (request.QueryRequestModel.CustomerId != 0)
            {
                customerCardCategoryQuery = customerCardCategoryQuery.Where(x => x.CustomerId == request.QueryRequestModel.CustomerId);
            }

            var customerCardCategories = await customerCardCategoryQuery.ToListAsync();
            return _mapper.Map<IEnumerable<GetCustomerCardCategoryQueryable_Dto>>(customerCardCategories);
        }
    }
}
