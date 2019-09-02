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

namespace FleetControl.Application.Queries.CardShipmentAddress
{
    public class GetCardShipmentAddressQueryable_QueryHandler : IRequestHandler<GetCardShipmentAddressQueryable_Query, IEnumerable<GetCardShipmentAddressQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetCardShipmentAddressQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCardShipmentAddressQueryable_Dto>> Handle(GetCardShipmentAddressQueryable_Query request, CancellationToken cancellationToken)
        {
            var CardShipmentAddressQuery = _context.CardAddress.AsQueryable();

            if (request.QueryRequestModel.CustomerId != 0)
            {
                CardShipmentAddressQuery = CardShipmentAddressQuery.Where(x => x.CustomerId == request.QueryRequestModel.CustomerId);
            }

            var customerCardCategories = await CardShipmentAddressQuery.ToListAsync();
            return _mapper.Map<IEnumerable<GetCardShipmentAddressQueryable_Dto>>(customerCardCategories);
        }
    }
}
