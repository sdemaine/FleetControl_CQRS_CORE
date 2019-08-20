using System;
using System.Collections.Generic;
using System.Text;

namespace FleetControl.Application.Queries
{
    public abstract class QueryViewModel
    {
        public int RecordCount { get; }

        public string PreviousPage { get; }

        public string NextPage { get; }

        public QueryViewModel(int recordCount, string previousPage, string nextPage)
        {
            RecordCount = recordCount;
            PreviousPage = previousPage;
            NextPage = nextPage;
        }
    }
}
