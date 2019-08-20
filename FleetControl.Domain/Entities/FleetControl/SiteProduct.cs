using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetControl.Domain
{
    [Table("SiteProduct")]
    public class SiteProduct : EntityBase
    {
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        public int SiteId { get; set; }

        public virtual Site Site { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
