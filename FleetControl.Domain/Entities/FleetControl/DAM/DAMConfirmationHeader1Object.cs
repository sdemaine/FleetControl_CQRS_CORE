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
    public class DAMConfirmationHeader1Object
    {
        [FieldFixedLength(2)]
        public string EnterpriseId;

        [FieldFixedLength(5)]
        public string SenderId;

        [FieldFixedLength(2)]
        public string ClientCode;

        [FieldFixedLength(4)]
        public string ControlNumber;

        [FieldFixedLength(2)]
        public string RecordType;

        [FieldFixedLength(40)]
        public string CompanyName;

        [FieldFixedLength(2)]
        public string VersionNumber;

        [FieldFixedLength(25)]
        public string ProcessName;

        [FieldFixedLength(7)]
        public string TransmissionDate;

        [FieldFixedLength(6)]
        public string TransmissionTime;

        [FieldFixedLength(191)]
        public string Filler1;

        [FieldFixedLength(8)]
        public string ProcessDate;

        [FieldFixedLength(6)]
        public string ProcessTime;

        [FieldFixedLength(300)]
        public string Filler2;

    }
}
