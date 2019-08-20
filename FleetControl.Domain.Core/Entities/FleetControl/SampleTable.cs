using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("SampleTable")]
    public class SampleTable : EntityBase
    {
        [DataMember]
        public string Name { get; set; }
    }
}
