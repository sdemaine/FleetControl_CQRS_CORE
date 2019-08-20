using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CustClass")]
    public class CustomerClass : EntityBase
    {
        [DataMember]
        public int AccountNumber { get; set; }

        [DataMember]
        [Column("CustClassId")]
        [MaxLength(10)]
        public string CustomerClassExternalId { get; set; }   //.. PK

        [DataMember]
        [Column("CustClassDesc")]
        [MaxLength(30)]
        public string Description { get; set; }

        [DataMember]
        public decimal MaxFuel { get; set; }

        [DataMember]
        public decimal MinRange { get; set; }

        [DataMember]
        public decimal MaxRange { get; set; }

        [DataMember]
        public string AllowedProducts { get; set; }

        [DataMember]
        public string ProductsNotAllowed { get; set; }

        [DataMember]
        public DateTime? LastUpdated { get; set; }

        [DataMember]
        public int? CustomerId { get; set; }

        [DataMember]
        public int? ExternalCustomerId { get; set; }
    }
}
