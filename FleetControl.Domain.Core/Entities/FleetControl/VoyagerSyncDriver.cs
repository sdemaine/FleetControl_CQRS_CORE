using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("VoyagerSyncDriver")]
    public class VoyagerSyncDriver : EntityBase
    {
        [DataMember]
        public int AccountNumber { get; set; }

        [DataMember]
        public string ExternalDriverId { get; set; }

        [DataMember]
        [Column("NameLast")]
        [Display(Name = "Last Name")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [DataMember]
        [Column("NameFirst")]
        [Display(Name = "First Name")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Middle Initial")]
        public string MiddleInitial { get; set; }

        [DataMember]
        [Display(Name = "Pin")]
        public int Pin { get; set; }

        [DataMember]
        [Display(Name = "Last Activity Date")]
        public DateTime? LastActivityDate { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Lock Code")]
        public string LockCode { get; set; }

        [DataMember]
        public DateTime? LockDate { get; set; }

        [DataMember]
        [MaxLength(10)]
        [Display(Name = "Their Employee Number")]
        public string TheirEmployeeNumber { get; set; }

        [DataMember]
        public int DriverLevel2Id { get; set; }

        [DataMember]
        [Display(Name = "Org Level 1")]
        public int? DriverLevel3Id { get; set; }

        [DataMember]
        [Display(Name = "Org Level 2")]
        public int? DriverLevel4Id { get; set; }

        [DataMember]
        [Display(Name = "Org Level 3")]
        public int? DriverLevel5Id { get; set; }

        [DataMember]
        [Display(Name = "Org Level 4")]
        public int? DriverLevel6Id { get; set; }

        [DataMember]
        [Display(Name = "Org Level 5")]
        public int? DriverLevel7Id { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string DriverLevel2Name { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string DriverLevel3Name { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string DriverLevel4Name { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string DriverLevel5Name { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string DriverLevel6Name { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string DriverLevel7Name { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string Class { get; set; }

        [DataMember]
        public int Sequence { get; set; }

        [DataMember]
        public int MENU { get; set; }

        [DataMember]
        public StatusMode Status { get; set; }

        [DataMember]
        public int UseCount { get; set; }

        [DataMember]
        public decimal Quantity { get; set; }

        [DataMember]
        public int? MinVehc { get; set; }

        [DataMember]
        public int? MaxVehc { get; set; }

        [DataMember]
        [MaxLength(13)]
        [Display(Name = "Driver User Code 1")]
        public string DriverUserCode1 { get; set; }

        [MaxLength(10)]
        [DataMember]
        [Display(Name = "Driver User Code 2")]
        public string DriverUserCode2 { get; set; }

        [MaxLength(8)]
        [DataMember]
        [Display(Name = "Driver User Code 3")]
        public string DriverUserCode3 { get; set; }

        [MaxLength(8)]
        [DataMember]
        [Display(Name = "Driver User Code 4")]
        public string DriverUserCode4 { get; set; }

        [MaxLength(8)]
        [DataMember]
        [Display(Name = "Driver User Code 5")]
        public string DriverUserCode5 { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public BooleanEnum Synchronized { get; set; }
    }
}
