using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    public class Product : EntityBase
    {
        [DataMember]
        [Column("ProdCode")]
        public string ProductCode { get; set; }

        [Column("ExternalProductId")]
        [DataMember]
        public int? ExternalProductId { get; set; }

        [DataMember]
        [Column("ProdDesc")]
        public string ProductDescription { get; set; }

        [DataMember]
        [Column("ProdSumDesc")]
        public string ProductSumDescription { get; set; }

        [DataMember]
        [Column("ProdType")]
        public string ProductType { get; set; }

        [DataMember]
        [Column("ProdAbbrev")]
        public string ProductAbbreviation { get; set; }

        [DataMember]
        [Column("WinC6ProductName")]
        public string WinC6ProductName { get; set; }

        [DataMember]
        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
