using AutoMapper;
using FleetControl.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Samples.GetSampleQueryable
{
    public class GetSampleQueryable_QueryHandler : IRequestHandler<GetSampleQueryable_Query, IEnumerable<GetSampleQueryable_Dto>>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetSampleQueryable_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<IEnumerable<GetSampleQueryable_Dto>> Handle(GetSampleQueryable_Query request, CancellationToken cancellationToken)
        {
            //var SamplesQuery = _context.Sample.AsQueryable();

            //if (request.QueryRequestModel.ActiveOnly)
            //{
            //    SamplesQuery = SamplesQuery.Where(x => x.Active == true);
            //}

            //if (request.QueryRequestModel.SearchQuery != null && request.QueryRequestModel.SearchQuery != string.Empty)
            //{
            //    SamplesQuery = SamplesQuery.Where(x => x.Name.ToLower().Contains(request.QueryRequestModel.SearchQuery.ToLower()));
            //}

            //var Samples = SamplesQuery.AsEnumerable();


            //return Task.Run(() =>  _mapper.Map<IEnumerable<GetSampleQueryable_Dto>>(Samples.ToList()));

            throw new NotImplementedException();
        }
    }
}