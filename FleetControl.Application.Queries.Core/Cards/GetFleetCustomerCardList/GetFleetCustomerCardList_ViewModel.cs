using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Cards
{
    public class GetFleetCustomerCardList_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetCustomerCardList_Dto> Cards { get; }

        public GetFleetCustomerCardList_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetFleetCustomerCardList_Dto> cards) : base(recordCount, previousPage, nextPage)
        {
            Cards = cards;
        }
    }
}
