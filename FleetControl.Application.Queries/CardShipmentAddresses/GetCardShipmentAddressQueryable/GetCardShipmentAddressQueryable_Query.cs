using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.CardShipmentAddress
{
    public class GetCardShipmentAddressQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetCardShipmentAddressQueryable_Dto>>
    {
        public QueryRequestModel QueryRequestModel { get; }

        public GetCardShipmentAddressQueryable_Query(QueryRequestModel queryRequestModel)
        {
            QueryRequestModel = queryRequestModel;
        }
    }
}
