using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("ContractTaxLocation")]
    public class ContractTaxLocation : EntityBase
    {
        [DataMember]
        public int CurrentTaxLocationId { get; set; }

        [DataMember]
        public int ContractTaxLocaleId { get; set; }

        [DataMember]
        public int PricingLocationGroupId { get; set; }

        [DataMember]
        public DateTime FromDate { get; set; }

        [DataMember]
        public DateTime? ToDate { get; set; }
    }
}
