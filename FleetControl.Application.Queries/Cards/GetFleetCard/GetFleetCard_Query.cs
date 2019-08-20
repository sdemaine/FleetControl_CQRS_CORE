using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Cards
{
    public class GetFleetCard_Query : IRequest<GetFleetCard_ViewModel>
    {
        public int CardId { get; set; }
    }
}
