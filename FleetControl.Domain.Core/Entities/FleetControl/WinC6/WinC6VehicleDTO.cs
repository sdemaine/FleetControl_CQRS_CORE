using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    public class WinC6VehicleDTO
    {
        public string IdNumber { get; set; }
        public string Description { get; set; }
        public string UniqueNumber { get; set; }
        public string Account { get; set; }
        public string Class { get; set; }
        public string Odometer { get; set; }
        public string Pin { get; set; }
        public string Sequence { get; set; }
        public bool Deleted { get; set; }
        public DateTime LastDate { get; set; }
        public string LastTime { get; set; }
        public string UseCount { get; set; }
        public DateTime Issued { get; set; }
        public string MeterType { get; set; }
        public string Qty { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool Maint { get; set; }
        public string MaintOdometer { get; set; }
        public string MaintMiles { get; set; }
        public string WarningSequence { get; set; }
        public string ShutoutSequence { get; set; }
        public string Warnings { get; set; }
        public string CurrentWarnings { get; set; }
        public DateTime LastOdometer { get; set; }
        public string CustomerId { get; set; }

        public override string ToString()
        {
            return string.Format("Account: {0:0.00} \t Id: {1} \t Description: {2} \t Pin: {3}", this.Account, this.IdNumber, this.Description, this.Pin);
        }
    }
}
