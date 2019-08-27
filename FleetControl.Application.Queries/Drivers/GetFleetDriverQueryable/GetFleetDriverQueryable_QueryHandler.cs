using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriverQueryable_QueryHandler : IRequestHandler<GetFleetDriverQueryable_Query, IEnumerable<GetFleetDriverQueryable_ViewDto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetDriverQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetFleetDriverQueryable_ViewDto>> Handle(GetFleetDriverQueryable_Query request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Id == request.CustomerId);

            var drivers = _context.Driver.Where(x => x.CustomerId == request.CustomerId).AsEnumerable();

            //IEnumerable<GetFleetDriverQueryable_ViewDto> drivers = _mapper.Map<IEnumerable<GetFleetDriverQueryable_ViewDto>>(await _context.Driver.Where(x => x.CustomerId == request.CustomerId).ToAsyncEnumerable());

            ////if (customer != null)
            ////{
            ////    //drivers = await _context.Driver.Where(x => x.CustomerId == customer.Id).ToListAsync();
            ////    drivers = _mapper.Map<IQueryable<GetFleetDriverQueryable_ViewDto>>(_context.Driver.Where(x => x.CustomerId == request.CustomerId));
            ////}

            return _mapper.Map<IEnumerable<GetFleetDriverQueryable_ViewDto>>(drivers);
        }

        //public IEnumerable<GetFleetDriverQueryable_ViewDto> Handle(GetFleetDriverQueryable_Query request, CancellationToken cancellationToken)
        //{
        //    // var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Id == request.CustomerId);

        //    var drivers = _context.Driver.Where(x => x.CustomerId == request.CustomerId).AsEnumerable();

        //    //IEnumerable<GetFleetDriverQueryable_ViewDto> drivers = _mapper.Map<IEnumerable<GetFleetDriverQueryable_ViewDto>>(await _context.Driver.Where(x => x.CustomerId == request.CustomerId).ToAsyncEnumerable());

        //    ////if (customer != null)
        //    ////{
        //    ////    //drivers = await _context.Driver.Where(x => x.CustomerId == customer.Id).ToListAsync();
        //    ////    drivers = _mapper.Map<IQueryable<GetFleetDriverQueryable_ViewDto>>(_context.Driver.Where(x => x.CustomerId == request.CustomerId));
        //    ////}

        //    return _mapper.Map<IEnumerable<GetFleetDriverQueryable_ViewDto>>(drivers);
        //}
    }
}
