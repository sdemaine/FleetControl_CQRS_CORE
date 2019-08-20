using FleetControl.Core;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    public class CardCategory : EntityBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
