using FleetControl.Application.Queries.Cards;
using MediatR;

namespace FleetControl.Application.Queries.Cards.GetFleetCardList
{
    public class GetFleetCardListQuery : IRequest<GetFleetCardList_ViewModel>
    {
        public QueryRequestModel QueryRequest { get; }

        public GetFleetCardListQuery(QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
        }
    }
}
