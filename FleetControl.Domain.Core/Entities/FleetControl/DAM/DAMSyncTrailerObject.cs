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
    public class DAMSyncTrailerObject
    {
        [FieldFixedLength(1)]
        public string RecordType;

        [FieldFixedLength(9)]
        public string Filler1;

        [FieldFixedLength(1)]
        public string Filler2;

        [FieldFixedLength(8)]
        public string CardCount;

        [FieldFixedLength(1)]
        public string Filler3;

        [FieldFixedLength(8)]
        public string VehicleCount;

        [FieldFixedLength(1)]
        public string Filler4;

        [FieldFixedLength(8)]
        public string DriverCount;

        [FieldFixedLength(103)]
        public string Filler5;

        [FieldFixedLength(260)]
        public string Filler6;
    }
}
