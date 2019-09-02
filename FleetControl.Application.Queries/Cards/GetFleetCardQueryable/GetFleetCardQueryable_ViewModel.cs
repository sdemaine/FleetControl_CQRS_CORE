using FleetControl.Application.Queries.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Cards
{
    public class GetFleetCardQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetCardQueryable_Dto> Cards { get; }

        public GetFleetCardQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetFleetCardQueryable_Dto> cards) : base(recordCount, previousPage, nextPage)
        {
            Cards = cards;
        }
    }
}
