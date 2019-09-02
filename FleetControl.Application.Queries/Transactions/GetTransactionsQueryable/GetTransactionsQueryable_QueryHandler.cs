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

namespace FleetControl.Application.Queries.Transactions
{
    public class GetTransactionsQueryable_QueryHandler : IRequestHandler<GetTransactionsQueryable_Query, IEnumerable<GetTransactionsQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetTransactionsQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetTransactionsQueryable_Dto>> Handle(GetTransactionsQueryable_Query request, CancellationToken cancellationToken)
        {
            var TransactionsQuery = _context.Transactions.AsQueryable();

            if (request.FromDate != null && request.ToDate != null)
            {
                TransactionsQuery = TransactionsQuery.Where(x => x.TransactionDate >= request.FromDate && x.TransactionDate <= request.ToDate);
            }


            if (request.CustomerId != 0)
            {
                TransactionsQuery = TransactionsQuery.Where(x => x.CustomerId == request.CustomerId);
            }

            //if (request.ActiveOnly)
            //{
            //    TransactionsQuery = TransactionsQuery.Where(x => x.Status == Core.StatusMode.Active);
            //}

            //if (request.QueryRequestModel.SearchQuery != null && request.QueryRequestModel.SearchQuery != string.Empty)
            //{
            //    TransactionsQuery = TransactionsQuery.Where(x => x.LastName.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()) || x.FirstName.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()));
            //}


            //var Transactions = await TransactionsQuery.ToListAsync();

            return _mapper.Map<IEnumerable<GetTransactionsQueryable_Dto>>(TransactionsQuery.AsEnumerable());
        }
    }
}
