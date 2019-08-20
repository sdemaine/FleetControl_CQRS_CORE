using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CustomerGroup")]
    public class CustomerGroup : EntityBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}
