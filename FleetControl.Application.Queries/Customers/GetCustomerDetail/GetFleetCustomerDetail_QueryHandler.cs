using System.Threading;
using System.Threading.Tasks;
using MediatR;
using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerDetail_QueryHandler : IRequestHandler<GetFleetCustomerDetail_Query, GetFleetCustomerDetail_Model>
    {
        private readonly IFleetControlDbContext _context;

        public GetFleetCustomerDetail_QueryHandler(IFleetControlDbContext context)
        {
            _context = context;
        }

        public async Task<GetFleetCustomerDetail_Model> Handle(GetFleetCustomerDetail_Query request, CancellationToken cancellationToken)
        {
            //var entity = await _context.Customer
            //    .FindAsync(request.Id);

            //if (entity == null)
            //{
            //    throw new NotFoundException(nameof(Customer), request.Id);
            //}

            //return FleetCustomerDetailModel.Create(entity);
            return null;
        }
    }
}
