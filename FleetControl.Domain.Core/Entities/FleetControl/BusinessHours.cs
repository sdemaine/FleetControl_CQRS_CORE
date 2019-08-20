using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("BusinessHours")]
    public class BusinessHours : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        public bool ClosedSunday { get; set; }

        public bool ClosedMonday { get; set; }

        public bool ClosedTuesday { get; set; }

        public bool ClosedWednesday { get; set; }

        public bool ClosedThursday { get; set; }

        public bool ClosedFriday { get; set; }

        public bool ClosedSaturday { get; set; }

        public string SundayOpen { get; set; }

        public string SundayClose { get; set; }

        public string MondayOpen { get; set; }

        public string MondayClose { get; set; }

        public string TuesdayOpen { get; set; }

        public string TuesdayClose { get; set; }

        public string WednesdayOpen { get; set; }

        public string WednesdayClose { get; set; }

        public string ThursdayOpen { get; set; }

        public string ThursdayClose { get; set; }

        public string FridayClose { get; set; }

        public string FridayOpen { get; set; }

        public string SaturdayOpen { get; set; }

        public string SaturdayClose { get; set; }

        public bool Sunday24Hours { get; set; }

        public bool Monday24Hours { get; set; }

        public bool Tuesday24Hours { get; set; }

        public bool Wednesday24Hours { get; set; }

        public bool Thursday24Hours { get; set; }

        public bool Friday24Hours { get; set; }

        public bool Saturday24Hours { get; set; }

    }
}
