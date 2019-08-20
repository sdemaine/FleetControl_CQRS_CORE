using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("FuelMasterTransactionLog")]
    public class FuelMasterTransactionLog : EntityBase
    {
        [DataMember]
        public int TranNum { get; set; }

        [DataMember]
        public string CustId { get; set; }

        [DataMember]
        public string SiteId { get; set; }

        [DataMember]
        public string VehicleId { get; set; }

        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public int Hose { get; set; }

        [DataMember]
        public DateTime TranTime { get; set; }

        [DataMember]
        public double Quantity { get; set; }

        [DataMember]
        public int Product { get; set; }

        [DataMember]
        public int InterfaceDatasourceId { get; set; }

    }
}
