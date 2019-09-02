using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Transactions
{
    public class GetTransactionsQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetTransactionsQueryable_Dto> Transactions { get; }

        public GetTransactionsQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetTransactionsQueryable_Dto> transactions) : base(recordCount, previousPage, nextPage)
        {
            Transactions = transactions;
        }
    }

    
}
