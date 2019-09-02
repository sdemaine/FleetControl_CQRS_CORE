using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Samples.GetSampleQueryable
{
    public class GetSampleQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetSampleQueryable_Dto> Samples { get; }

        public GetSampleQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetSampleQueryable_Dto> samples) : base(recordCount, previousPage, nextPage)
        {
            Samples = samples;
        }
    }
}
