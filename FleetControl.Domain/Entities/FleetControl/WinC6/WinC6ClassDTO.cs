using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    public class WinC6ClassDTO
    {
        public string Class { get; set; }
        public string Description { get; set; }
        public string MaxFuel { get; set; }
        public string MinRange { get; set; }
        public string MaxRange { get; set; }
        public string AllowedProducts { get; set; }
        public string ProductsNotAllowed { get; set; }
        public DateTime? LastUpdated { get; set; }

        public override string ToString()
        {
            return string.Format("ClassId: {0} \t Description: {1} \t MaxFuel: {2} \t MinRange: {3} \t MaxRange: {4}");
        }
    }
}
