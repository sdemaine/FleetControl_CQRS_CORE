using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("WinC6ImportEmployees")]
    public partial class WinC6ImportEmployees : Sprague.Domain.EntityBase<Domain.WinC6ImportEmployees, Core.WinC6ImportEmployees, Sprague.Core.IFleetControlDbContext>
    {
        [DataMember]
        public string IdNumber { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Account { get; set; }

        [DataMember]
        public int Class { get; set; }

        [DataMember]
        public string Pin { get; set; }

        [DataMember]
        public int Sequence { get; set; }

        [DataMember]
        public bool Menu { get; set; }

        [DataMember]
        public bool Deleted { get; set; }

        [DataMember]
        public DateTime? LastDate { get; set; }

        [DataMember]
        public string LastTime { get; set; }

        [DataMember]
        public int UseCount { get; set; }

        [DataMember]
        public double Quantity { get; set; }

        [DataMember]
        public DateTime? LastUpdated { get; set; }
    }
}
