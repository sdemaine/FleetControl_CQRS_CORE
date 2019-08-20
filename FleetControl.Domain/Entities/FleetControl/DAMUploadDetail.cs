using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("DAMUploadDetail")]
    public class DAMUploadDetail : EntityBase
    {
        [DataMember]
        public int ControlNumber { get; set; }

        [DataMember]
        public DateTime UploadDate { get; set; }

        [DataMember]
        public int TotalCardsCreated { get; set; }

        [DataMember]
        public int TotalVehiclesCreated { get; set; }

        [DataMember]
        public int TotalDriversCreated { get; set; }

        [DataMember]
        public int TotalCardsUpdated { get; set; }

        [DataMember]
        public int TotalVehiclesUpdated { get; set; }

        [DataMember]
        public int TotalDriversUpdated { get; set; }

        [DataMember]
        public int TotalCards { get; set; }

        [DataMember]
        public int TotalVehicles { get; set; }

        [DataMember]
        public int TotalDrivers { get; set; }
    }
}
