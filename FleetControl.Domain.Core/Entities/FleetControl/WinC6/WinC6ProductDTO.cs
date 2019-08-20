using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    public class WinC6ProductDTO
    {
        public int ProductNumber { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public bool Fuel { get; set; }

        public override string ToString()
        {
            return string.Format("Product #: {0} \t Description: {1} \t Unit: {2} \t Fuel: {3}", ProductNumber, Description, Unit, Fuel);
        }
    }
}
