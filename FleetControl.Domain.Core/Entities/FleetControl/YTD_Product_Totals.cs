using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("YTD_Product_Totals")]
    public class YTD_Product_Totals : EntityBase
    {
        [DataMember]
        [Column("CustomerNumber")]
        [MaxLength(5)]
        public string CustomerNumber { get; set; }

        [DataMember]
        [Column("Product")]
        [MaxLength(2)]
        public string ProductCode { get; set; }

        [DataMember]
        [Column("_Year")]
        [MaxLength(4)]
        public string Year { get; set; }

        [DataMember]
        [Column("_Month")]
        [MaxLength(2)]
        public string Month { get; set; }

        [DataMember]
        [Column("Total")]
        public double Total { get; set; }

        [DataMember]
        [Column("Dollars")]
        public double Dollars { get; set; }
    }
}
