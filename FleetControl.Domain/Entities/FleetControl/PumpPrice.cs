using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("PumpPrices")]
    public class PumpPrice : EntityBase
    {
        [DataMember]
        [Column("Site")]
        [MaxLength(6)]
        public string Site { get; set; }

        [DataMember]
        [Column("Date")]
        public DateTime Date { get; set; }

        [DataMember]
        [Column("RegUnleaded")]
        public double RegUnleaded { get; set; }

        [DataMember]
        [Column("MidUnleaded")]
        public double MidUnleaded { get; set; }

        [DataMember]
        [Column("PremUnleaded")]
        public double PremUnleaded { get; set; }

        [DataMember]
        [Column("Diesel")]
        public double Diesel { get; set; }
    }
}
