using FleetControl.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Core
{
    public class PersistentObjectBase
    {
        public virtual int CreatedByUserId { get; set; }
        [DataMember]
        [Required]
        public DateTime CreatedDate { get; set; }
        [NotMapped]
        public ExtensionDataObject ExtensionData { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [Key]
        public int Id { get; set; }
        [DataMember]
        [NotMapped]
        public ObjectState ObjectState { get; set; }
        [DataMember]
        [Timestamp]
        public byte[] RowVersion { get; set; }
        [DataMember]
        [Required]
        public Guid UniqueIdentifier { get; set; }
        [DataMember]
        public int? UpdatedByUserId { get; set; }
        [DataMember]
        public DateTime? UpdatedDate { get; set; }

        //[NotMapped]
        //public virtual List<ValidationError> ValidationErrors { get; set; }
    }
}
