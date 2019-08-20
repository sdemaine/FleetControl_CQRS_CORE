using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("VoyagerDriver")]
    public class VoyagerDriver : EntityBase
    {
        [DataMember]
        public int AccountNumber { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public int DriverId { get; set; }

        [DataMember]
        public StatusMode Status { get; set; }

        [DataMember]
        public DateTime? StatusDate { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleInitial { get; set; }

        [DataMember]
        public string OrgLevel2Name { get; set; }

        [DataMember]
        public string OrgLevel3Name { get; set; }

        [DataMember]
        public string OrgLevel4Name { get; set; }

        [DataMember]
        public string OrgLevel5Name { get; set; }

        [DataMember]
        public string OrgLevel6Name { get; set; }

        [DataMember]
        public string OrgLevel7Name { get; set; }

        [DataMember]
        public string UserCode1 { get; set; }

        [DataMember]
        public string UserCode2 { get; set; }

        [DataMember]
        public string UserCode3 { get; set; }

        [DataMember]
        public string UserCode4 { get; set; }

        [DataMember]
        public string UserCode5 { get; set; }

        [DataMember]
        public int OrgLevel2Id { get; set; }

        [DataMember]
        public int OrgLevel3Id { get; set; }

        [DataMember]
        public int OrgLevel4Id { get; set; }

        [DataMember]
        public int OrgLevel5Id { get; set; }

        [DataMember]
        public int OrgLevel6Id { get; set; }

        [DataMember]
        public int OrgLevel7Id { get; set; }
    }
}
