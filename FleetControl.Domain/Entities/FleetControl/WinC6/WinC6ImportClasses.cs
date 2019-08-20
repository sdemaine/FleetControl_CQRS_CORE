using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("WinC6ImportClasses")]
    public partial class WinC6ImportClasses : Sprague.Domain.EntityBase<Domain.WinC6ImportClasses, Core.WinC6ImportClasses, Sprague.Core.IFleetControlDbContext>
    {
        [DataMember]
        public int ClassId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double MaxFuel { get; set; }

        [DataMember]
        public double MinRange { get; set; }

        [DataMember]
        public double MaxRange { get; set; }

        [DataMember]
        public string AllowedProducts { get; set; }

        [DataMember]
        public string ProductsNotAllowed { get; set; }

        [DataMember]
        public DateTime? LastUpdated { get; set; }
    }
}
