using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetControl.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomer_QueryHandler : IRequestHandler<GetFleetCustomer_Query, GetFleetCustomer_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCustomer_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetCustomer_ViewModel> Handle(GetFleetCustomer_Query request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.BAID == request.Baid);
            return new GetFleetCustomer_ViewModel(1, "previousPage", "nextPage", _mapper.Map<GetFleetCustomer_Dto>(customer));
        }
    }
}
