using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("Driver")]
    public class Driver : EntityBase
    {
        [DataMember]
        public int AccountNumber { get; set; }

        [DataMember]
        [MaxLength(20)]
        public string ExternalDriverId { get; set; }

        [DataMember]
        [Column("NameLast")]
        [Display(Name = "Last Name")]
        [MaxLength(20)]
        [StringLength(20, ErrorMessage = "Last Name must be a maximum of 20 characters")]
        public string LastName { get; set; }

        [DataMember]
        [Column("NameFirst")]
        [Display(Name = "First Name")]
        [MaxLength(20)]
        [StringLength(20, ErrorMessage = "First Name must be a maximum of 20 characters")]
        public string FirstName { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Middle Initial")]
        //[StringLength(20, ErrorMessage = "Middle Initial can only be 1 character in length")]
        //[RegularExpression(@"^[a-zA-Z]{0,1}", ErrorMessage = "Middle Initial must be a single letter or left blank")]
        public string MiddleInitial { get; set; }

        [DataMember]
        [Display(Name = "Pin")]
        public string Pin { get; set; }

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
        [Display(Name = "Daily Transaction Limit")]
        public int? DailyTransactionLimit { get; set; }

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
        public virtual Customer Customer { get; set; }

        [DataMember]
        public BooleanEnum Synchronized { get; set; }

        [DataMember]
        public bool? SubmitPending { get; set; }

        [DataMember]
        [Display(Name = "ClassId")]
        public int? ClassId { get; set; }

        [DataMember]
        public bool IsConsignment { get; set; }

        [DataMember]
        public DateTime? ExternalDeleteDate { get; set; }

        [DataMember]
        public bool IsFuelMaster { get; set; }

        [DataMember]
        public bool IsWinC6 { get; set; }

        [DataMember]
        public bool IsVoyager { get; set; }

        [DataMember]
        public bool ExistsInVoyager { get; set; }
    }
}
