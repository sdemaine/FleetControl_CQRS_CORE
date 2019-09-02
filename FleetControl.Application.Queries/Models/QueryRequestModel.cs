using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries
{
    public class QueryRequestModel : IQueryRequestModel
    {
        public int Skip { get; set; }

        public int Take { get; set; }

        public string SearchQuery { get; set; }

        public string SortBy { get; set; }

        public string SortDirection { get; set; }

        public bool ActiveOnly { get; set; }

        public int Baid { get; set; }

        public int CustomerId { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}
