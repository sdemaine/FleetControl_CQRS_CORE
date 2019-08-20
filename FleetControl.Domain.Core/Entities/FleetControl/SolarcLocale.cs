using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetControl.Domain
{
    [Table("SolarcLocale")]
    public class SolarcLocale : EntityBase
    {
        public int OfficeBAID { get; set; }

        [MaxLength(1)]
        public string LocaleStatus { get; set; }

        public int LocaleTypeId { get; set; }

        public int OfficeLocaleId { get; set; }

        public string LocaleName { get; set; }

        [MaxLength(20)]
        public string LocaleAbbreviation { get; set; }
    }
}
