using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Cards.GetFleetCardList
{
    public class GetFleetCardList_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetCardList_Dto> Cards { get; }

        public GetFleetCardList_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetFleetCardList_Dto> Cards) : base(recordCount, previousPage, nextPage)
        {
            Cards = Cards;
        }
    }
}
