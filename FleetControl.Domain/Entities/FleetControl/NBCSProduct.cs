using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("NBCSProducts")]
    public class NBCSProduct : EntityBase
    {
        [DataMember]
        public double ProductNumber { get; set; }

        [DataMember]
        [MaxLength(16)]
        public string ProductDescription { get; set; }

        [DataMember]
        [Column("Units")]
        [MaxLength(10)]
        public string UnitsOfMeasure { get; set; }

        [DataMember]
        public bool Fuel { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string FleetCorProduct { get; set; }

        [DataMember]
        [Column("PrdctId")]
        public int ProductId { get; set; }

    }
}
