using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetControl.Domain
{
    [Table("RetailAdder")]
    public class RetailAdder : EntityBase
    {
        public int CustomerId { get; set; }

        public decimal AdderAmount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
