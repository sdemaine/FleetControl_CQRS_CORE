using Sprague.FleetControl.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    public class WinC6ActiveDTO
    {
        public DateTime Date { get; set; }
        public string Site { get; set; }
        public string SiteName { get; set; }
        public string Island { get; set; }
        public string Sequence { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string VehicleId { get; set; }
        public string VehicleUniqueNumber { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Tank { get; set; }
        public string Hose { get; set; }
        public string Product { get; set; }
        public string Odometer { get; set; }
        public string Hours { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Amount { get; set; }
        public string MilesPerGallon { get; set; }
        public bool Captured { get; set; }
        public string ShutdownReason { get; set; }
        public string CardData { get; set; }
        public string DriverNumber { get; set; }
        public string UnitNumber { get; set; }
        public string TrailorNumber { get; set; }
        public string Hubometer { get; set; }
        public string TrailerHub { get; set; }
        public string TripNumber { get; set; }
        public string Reefer { get; set; }
        public string ControlNumber { get; set; }
        public string ClassNumber { get; set; }
        public string ClassName { get; set; }
        public string Type { get; set; }
        
        public CardType CardType { get; set; }

        public override string ToString()
        {
            return string.Format("Account: {0} \t Date: {1} \t Price: {2} \t Quantity: {3} \t Vehicle #: {4} \t Employee: {5}",
                AccountName, Date, Price, Quantity, VehicleUniqueNumber, EmployeeName);
        }
    }
}
