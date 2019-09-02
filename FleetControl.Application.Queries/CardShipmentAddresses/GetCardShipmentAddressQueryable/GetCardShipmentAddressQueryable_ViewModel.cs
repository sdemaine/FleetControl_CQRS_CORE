using FleetControl.Application.Queries.CardShipmentAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.CardShipmentAddress
{
    public class GetCardShipmentAddressQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetCardShipmentAddressQueryable_Dto> CardShipmentAddresses { get; }

        public GetCardShipmentAddressQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetCardShipmentAddressQueryable_Dto> cardShipmentAddresses) : base(recordCount, previousPage, nextPage)
        {
            CardShipmentAddresses = cardShipmentAddresses;
        }
    }

    
}
