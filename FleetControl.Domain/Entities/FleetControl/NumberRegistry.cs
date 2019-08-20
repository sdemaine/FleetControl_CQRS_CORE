
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    [Table("NumberRegistry")]
    public class NumberRegistry : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string Number { get; set; }

        //[DataMember]
        //public EntityType EntityType { get; set; }

        [DataMember]
        public NumberType NumberType { get; set; }
    }
}
