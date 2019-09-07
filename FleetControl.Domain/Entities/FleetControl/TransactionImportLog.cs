using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("TransactionImportLog")]
    public class TransactionImportLog : EntityBase
    {
        [DataMember]
        public int NumberOfInvoices { get; set; }

        [DataMember]
        [Column(TypeName = "decimal(18,2)")]

        public decimal TotalProductUnits { get; set; }

        [DataMember]
        [Column(TypeName = "decimal(18,2)")]

        public decimal TotalProductAmount { get; set; }

        [DataMember]
        public DateTime? StatementDate { get; set; }

        [DataMember]
        public string Filename { get; set; }
    }
}
