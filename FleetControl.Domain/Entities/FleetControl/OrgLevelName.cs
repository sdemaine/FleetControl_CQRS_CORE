using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("OrgLevelName")]
    public class OrgLevelName : EntityBase
    {
        [DataMember]
        [Display(Name = "Org Level 1 Name")]
        public string Level3Name { get; set; }

        [DataMember]
        [Display(Name = "Org Level 2 Name")]
        public string Level4Name { get; set; }

        [DataMember]
        [Display(Name = "Org Level 3 Name")]
        public string Level5Name { get; set; }

        [DataMember]
        [Display(Name = "Org Level 4 Name")]
        public string Level6Name { get; set; }

        [DataMember]
        [Display(Name = "Org Level 5 Name")]
        public string Level7Name { get; set; }

        [DataMember]
        public int CustomerId { get; set; }
    }
}
