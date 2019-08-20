using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("TaxAreas")]
    public class TaxArea : EntityBase
    {
        [DataMember]
        [Column("TaxArea")]
        [MaxLength(2)]
        public string TaxAreaCode { get; set; }

        [DataMember]
        [Column("TaxAreaDesc")]
        [MaxLength(30)]
        public string TaxAreaDescription { get; set; }

        [DataMember]
        [Column("County")]
        [MaxLength(30)]
        public string County { get; set; }

        [DataMember]
        [Column("SalesTaxRegion")]
        [MaxLength(1)]
        public string SalesTaxRegion { get; set; }

        [DataMember]
        [Column("State")]
        [MaxLength(2)]
        public string State { get; set; }

        [DataMember]
        [Column("MCTD")]
        [MaxLength(1)]
        public string MCTD { get; set; }
    }
}
