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
    public class DAMConfirmationHeader2Object
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

        [FieldFixedLength(1)]
        public string ActionCode;

        [FieldFixedLength(40)]
        public string CompanyName;

        [FieldFixedLength(2)]
        public string VersionNumber;

        [FieldFixedLength(7)]
        public string TransmissionDate;

        [FieldFixedLength(6)]
        public string TransmissionTime;

        [FieldFixedLength(20)]
        public string UserReserve;

        [FieldFixedLength(168)]
        public string Filler1;

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
        public string Filler2;

    }
}
