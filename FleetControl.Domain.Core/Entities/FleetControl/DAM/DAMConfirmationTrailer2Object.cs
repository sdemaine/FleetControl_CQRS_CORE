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
    public class DAMConfirmationTrailer2Object
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

        [FieldFixedLength(7)]
        public string TransmitDate;

        [FieldFixedLength(7)]
        public string TotalRecords;

        [FieldFixedLength(257)]
        public string Filler1;

        [FieldFixedLength(8)]
        public string ProcessDate;

        [FieldFixedLength(6)]
        public string ProcessTime;

        [FieldFixedLength(300)]
        public string Filler2;

    }
}
