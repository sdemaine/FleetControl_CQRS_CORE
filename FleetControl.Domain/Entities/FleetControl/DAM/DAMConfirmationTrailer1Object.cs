using FileHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Domain
{
    [FixedLengthRecord(FixedMode.AllowMoreChars)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DAMConfirmationTrailer1Object
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

        [FieldFixedLength(196)]
        public string Filler5;

        [FieldFixedLength(5)]
        public string ErrorCode1;

        [FieldFixedLength(5)]
        public string ErrorCode2;

        [FieldFixedLength(5)]
        public string ErrorCode3;

        [FieldFixedLength(5)]
        public string ErrorCode4;

        [FieldFixedLength(8)]
        public string ProcessDate;

        [FieldFixedLength(6)]
        public string ProcessTime;

        [FieldFixedLength(300)]
        public string Filler1;
    }
}
