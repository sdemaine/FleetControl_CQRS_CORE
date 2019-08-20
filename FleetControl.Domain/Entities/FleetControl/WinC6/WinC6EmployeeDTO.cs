using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    public class WinC6EmployeeDTO
    {
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Class { get; set; }
        public string Pin { get; set; }
        public string Sequence { get; set; }
        public bool Menu { get; set; }
        public bool Deleted { get; set; }
        public DateTime LastDate { get; set; }
        public string LastTime { get; set; }
        public string UseCount { get; set; }
        public string Quantity { get; set; }
        public DateTime LastUpdated { get; set; }
        public string CustomerId { get; set; }

        public override string ToString()
        {
            return string.Format("{Account: {0} \t Name: {1} \t Pin: {2}", Account, Name, Pin);
        }
    }
}
