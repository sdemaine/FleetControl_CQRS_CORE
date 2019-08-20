using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("TransactionExceptionDetail")]
    public class TransactionExceptionDetail : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public virtual Customer Customer { get; set; }

        [DataMember]
        public int TransactionId { get; set; }

        [DataMember]
        public virtual Transaction Transaction { get; set; }

        [DataMember]
        public DateTime TransactionDate { get; set; }

        [DataMember]
        public int TransactionExceptionId { get; set; }

        [DataMember]
        public virtual TransactionException TransactionException { get; set; }
    }
}
