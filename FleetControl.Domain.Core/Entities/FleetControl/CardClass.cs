using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("CardClass")]
    public class CardClass : EntityBase
    {
        [DataMember]
        public string Class { get; set; }

        [DataMember]
        [MaxLength(20)]
        public string Description { get; set; }

        [DataMember]
        public double MaxFuel { get; set; }

        [DataMember]
        public double MinRange { get; set; }

        [DataMember]
        public double MaxRange { get; set; }

        [DataMember]
        public int? ProductId { get; set; }

        //[DataMember]
        //public virtual Product Product { get; set; }

        [DataMember]
        public string ProductsNotAllowed { get; set; }

        [DataMember]
        public DateTime? LastUpdated { get; set; }

        [DataMember]
        public int? AccountNumber { get; set; }
    }
}
