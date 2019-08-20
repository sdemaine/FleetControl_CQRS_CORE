using FleetControl.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers.GetFleetDriverList
{
    public class GetFleetDriverList_Dto
    {
        public string ExternalDriverId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleInitial { get; set; }

        public string Pin { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public string LockCode { get; set; }

        public DateTime? LockDate { get; set; }

        public string TheirEmployeeNumber { get; set; }

        public int? DailyTransactionLimit { get; set; }

        public int DriverLevel2Id { get; set; }

        public int? DriverLevel3Id { get; set; }

        public int? DriverLevel4Id { get; set; }

        public int? DriverLevel5Id { get; set; }

        public int? DriverLevel6Id { get; set; }

        public int? DriverLevel7Id { get; set; }

        public string Class { get; set; }

        public int Sequence { get; set; }

        public int MENU { get; set; }

        public StatusMode Status { get; set; }

        public int UseCount { get; set; }

        public decimal Quantity { get; set; }

        public int? MinVehc { get; set; }

        public int? MaxVehc { get; set; }

        public string DriverUserCode1 { get; set; }

        public string DriverUserCode2 { get; set; }

        public string DriverUserCode3 { get; set; }
        public string DriverUserCode4 { get; set; }

        public string DriverUserCode5 { get; set; }


        public BooleanEnum Synchronized { get; set; }

        public bool? SubmitPending { get; set; }

        public int? ClassId { get; set; }

        public bool IsConsignment { get; set; }

        public DateTime? ExternalDeleteDate { get; set; }

        public bool IsFuelMaster { get; set; }

        public bool IsWinC6 { get; set; }

        public bool IsVoyager { get; set; }

        public bool ExistsInVoyager { get; set; }
    }
}
