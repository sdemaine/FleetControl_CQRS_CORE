using FileHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    [FixedLengthRecord(FixedMode.AllowMoreChars)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DAMTrailerObject
    {
        [FieldFixedLength(2)]
        public string EnterpriseId;

        [FieldFixedLength(5)]
        public string SenderId;

        [FieldFixedLength(2)]
        public string ClientCode;

        [FieldFixedLength(4)]
        public string ControlNumber;

        [FieldFixedLength(7)]
        public string SequenceNumber;

        [FieldFixedLength(2)]
        public string RecordType;

        [FieldFixedLength(7)]
        public string TotalRecords;

        [FieldFixedLength(7)]
        public string TotalCardRecords;

        [FieldFixedLength(7)]
        public string TotalVehicleRecords;

        [FieldFixedLength(7)]
        public string TotalDriverRecords;

        [FieldFixedLength(20)]
        public string UserReserve;

        [FieldFixedLength(530)]
        public string Filler1;

    }
}
