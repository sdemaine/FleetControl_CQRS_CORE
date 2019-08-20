using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetControl.Domain
{
    [Table("TransactionError")]
    public class TransactionError : EntityBase
    {
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
    }
}
