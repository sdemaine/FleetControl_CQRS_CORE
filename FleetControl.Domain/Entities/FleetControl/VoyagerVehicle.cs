using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("VoyagerVehicle")]
    public class VoyagerVehicle : EntityBase
    {
        [DataMember]
        public int AccountNumber { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public int VehicleId { get; set; }

        [DataMember]
        public StatusMode Status { get; set; }

        [DataMember]
        public DateTime? StatusDate { get; set; }

        [DataMember]
        public string VinNumber { get; set; }

        [DataMember]
        public string VehicleDescription { get; set; }

        [DataMember]
        public string LicenseNumber { get; set; }

        [DataMember]
        public string LicenseState { get; set; }

        [DataMember]
        public int ProductType1 { get; set; }

        [DataMember]
        public int Product1Capacity { get; set; }

        [DataMember]
        public int ProductType2 { get; set; }

        [DataMember]
        public int Product2Capacity { get; set; }

        [DataMember]
        public int UnitsPerGallon { get; set; }

        [DataMember]
        public string UnitOfMeasure { get; set; }

        [DataMember]
        public int UnitPerGallonVariance { get; set; }

        [DataMember]
        public string OrgLevel2Name { get; set; }

        [DataMember]
        public string OrgLevel3Name { get; set; }

        [DataMember]
        public string OrgLevel4Name { get; set; }

        [DataMember]
        public string OrgLevel5Name { get; set; }

        [DataMember]
        public string OrgLevel6Name { get; set; }

        [DataMember]
        public string OrgLevel7Name { get; set; }

        [DataMember]
        public string UserCode1 { get; set; }

        [DataMember]
        public string UserCode2 { get; set; }

        [DataMember]
        public string UserCode3 { get; set; }

        [DataMember]
        public string UserCode4 { get; set; }

        [DataMember]
        public string UserCode5 { get; set; }

        [DataMember]
        public int OrgLevel2Id { get; set; }

        [DataMember]
        public int OrgLevel3Id { get; set; }

        [DataMember]
        public int OrgLevel4Id { get; set; }

        [DataMember]
        public int OrgLevel5Id { get; set; }

        [DataMember]
        public int OrgLevel6Id { get; set; }

        [DataMember]
        public int OrgLevel7Id { get; set; }
    }
}
