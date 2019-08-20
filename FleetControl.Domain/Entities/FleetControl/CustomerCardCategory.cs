using FleetControl.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    public class CustomerCardCategory : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public virtual Customer Customer { get; set; }

        [DataMember]
        public int CardCategoryId { get; set; }

        [DataMember]
        public virtual CardCategory CardCategory { get; set; }
    }
}
