using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("WinC6ImportVehicles")]
    public partial class WinC6ImportVehicles : Sprague.Domain.EntityBase<Domain.WinC6ImportVehicles, Core.WinC6ImportVehicles, Sprague.Core.IFleetControlDbContext>
    {
        [DataMember]
        public int IdNumber { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int UniqueNumber { get; set; }

        [DataMember]
        public int Account { get; set; }

        [DataMember]
        public int Class { get; set; }

        [DataMember]
        public string Odometer { get; set; }

        [DataMember]
        public string Pin { get; set; }

        [DataMember]
        public int Sequence { get; set; }

        [DataMember]
        public bool Deleted { get; set; }

        [DataMember]
        public DateTime? LastDate { get; set; }

        [DataMember]
        public string LastTime { get; set; }

        [DataMember]
        public int UseCount { get; set; }

        [DataMember]
        public DateTime? Issued { get; set; }

        [DataMember]
        public string MeterType { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public DateTime? LastUpdated { get; set; }

        [DataMember]
        public bool Maint { get; set; }

        [DataMember]
        public string MaintOdometer { get; set; }

        [DataMember]
        public string MaintMiles { get; set; }

        [DataMember]
        public int WarningSequence { get; set; }

        [DataMember]
        public int ShutoutSequence { get; set; }

        [DataMember]
        public int Warnings { get; set; }

        [DataMember]
        public int CurrentWarnings { get; set; }

        [DataMember]
        public DateTime? LastOdometer { get; set; }
    }
}
