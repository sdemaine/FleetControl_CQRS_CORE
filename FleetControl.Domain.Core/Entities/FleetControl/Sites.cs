using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("Sites")]
    public class Site : EntityBase
    {
        [DataMember]
        public double? SiteNumber { get; set; }

        [DataMember]
        public double? Island { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string SiteName { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string Address { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string City { get; set; }

        [DataMember]
        [MaxLength(2)]
        public string State { get; set; }

        [DataMember]
        [Column("Zip")]
        [MaxLength(15)]     //.. is this necessary ?? (9 digits is standard)
        public string ZipCode { get; set; }

        [DataMember]
        [Column("Phone")]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [DataMember]
        [MaxLength(30)]
        public string ModemNumber { get; set; }

        [DataMember]
        public double? Port { get; set; }

        [DataMember]
        [Column("Baud")]
        public double? BaudRate { get; set; }

        [DataMember]
        [MaxLength(1)]
        public string Parity{ get; set; }

        [DataMember]
        public double? DataBits{ get; set; }

        [DataMember]
        //[MaxLength(5)]
        public double? COS { get; set; }

        [DataMember]
        [MaxLength(17)]
        public string ReceiptLine1 { get; set; }

        [DataMember]
        [MaxLength(17)]
        public string ReceiptLine2 { get; set; }

        [DataMember]
        [MaxLength(17)]
        public string ReceiptLine3 { get; set; }

        [DataMember]
        [MaxLength(17)]
        public string ReceiptLine4 { get; set; }

        [DataMember]
        [Column("LastConnection")]
        public DateTime? DateOfLastConnection { get; set; }

        [DataMember]
        [Column("InitString")]
        [MaxLength(50)]
        public string InitializationString { get; set; }

        [DataMember]
        [Column("ICU_Init")]
        [MaxLength(40)]
        public string ICUInitialization { get; set; }

        [DataMember]
        [Column("ROM_Desc")]
        [MaxLength(40)]
        public string ROMDescription { get; set; }

        [DataMember]
        [Column("LcleId")]
        public int? LocaleId { get; set; }
    }
}
