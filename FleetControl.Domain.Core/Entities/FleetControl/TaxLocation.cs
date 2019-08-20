using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("TaxLocation")]
    public class TaxLocation : EntityBase
    {
        [DataMember]
        [Display(Name = "Solarc Tax Locale")]
        public int SolarcTaxLocaleId { get; set; }

        [DataMember]
        public string Name { get; set; }        
    }
}
