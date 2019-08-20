using FleetControl.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    [Table("WinC6TransactionLog")]
    public class WinC6TransactionLog : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int SequenceNumber { get; set; }

        [DataMember]
        public int SiteId { get; set; }

        [DataMember]
        public DateTime TransactionDate { get; set; }
    }
}
