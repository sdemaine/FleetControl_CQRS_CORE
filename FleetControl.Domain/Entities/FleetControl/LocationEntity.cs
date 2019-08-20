using FleetControl.Core;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    public class LocationEntity : EntityBase
    {
        public LocationEntity()
        {
            ObjectState = ObjectState.Unchanged;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public ObjectState ObjectState { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int TaxLocaleId { get; set; }
    }
}
