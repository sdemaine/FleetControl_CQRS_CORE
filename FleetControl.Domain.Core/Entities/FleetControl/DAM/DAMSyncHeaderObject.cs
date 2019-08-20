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
    public class DAMSyncHeaderObject
    {
        [FieldFixedLength(1)]
        public string RecordType;

        [FieldFixedLength(9)]
        public string Filler1;

        [FieldFixedLength(14)]
        public string FileName;

        [FieldFixedLength(26)]
        public string SenderName;

        [FieldFixedLength(40)]
        public string CustName;

        [FieldFixedLength(8)]
        public string FileDate;

        [FieldFixedLength(3)]
        public string FileType;

        [FieldFixedLength(39)]
        public string Filler2;

        [FieldFixedLength(360)]
        public string Filler3;
    }
}
