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
    public class DAMHeaderObject
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

        [FieldFixedLength(502)]
        public string Filler1;
    }
}
