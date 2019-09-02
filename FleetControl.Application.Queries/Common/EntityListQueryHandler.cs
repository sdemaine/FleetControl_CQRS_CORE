using AutoMapper;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Interfaces.Mapping;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Common
{
    public abstract class EntityListQueryHandler<Q, D>
        where D : QueryViewModel, IHaveCustomMapping
        where Q : IRequest
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;
        private QueryRequestModel _queryRequestModel;

        public EntityListQueryHandler(IFleetControlDbContext context, IMapper mapper, QueryRequestModel queryRequestModel)
        {
            _context = context;
            _mapper = mapper;
            _queryRequestModel = queryRequestModel;
        }

        public abstract Task<D> Handle(Q request, CancellationToken cancellationToken);
    }
}