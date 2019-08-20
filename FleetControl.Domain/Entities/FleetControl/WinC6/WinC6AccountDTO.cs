using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    public class WinC6AccountDTO
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public double Discount { get; set; }
        public string Contact { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
