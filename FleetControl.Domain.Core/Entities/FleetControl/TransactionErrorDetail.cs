using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("TransactionErrorDetail")]
    public class TransactionErrorDetail : EntityBase
    {
        [DataMember]
        public int? ImportedTransactionId { get; set; }

        [DataMember]
        public virtual ImportedTransaction ImportedTransaction { get; set; }

        [DataMember]
        public int TransactionErrorId { get; set; }

        [DataMember]
        public virtual TransactionError TransactionError { get; set; }
    }
}
