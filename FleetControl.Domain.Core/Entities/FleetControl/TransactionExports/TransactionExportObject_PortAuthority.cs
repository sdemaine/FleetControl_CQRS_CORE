using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace FleetControl.Domain
{
    [FixedLengthRecord()]
    public class TransactionExportObject_PortAuthority
    {
        [FieldFixedLength(1)]
        public string LetterC;

        [FieldFixedLength(4)]
        [FieldAlign(AlignMode.Right)]
        public string TranNo;

        [FieldFixedLength(8)]
        [FieldConverter(ConverterKind.Date, "yyyyMMdd")]
        public DateTime TranDate;

        [FieldFixedLength(4)]
        public string TranTime;

        [FieldFixedLength(7)]
        [FieldAlign(AlignMode.Right)]
        public string TheirVehicleNumber;

        [FieldFixedLength(4)]
        public string Field6;

        [FieldFixedLength(7)]
        [FieldAlign(AlignMode.Right)]
        public string TheirCardNumber;

        [FieldFixedLength(3)]
        public string Field8;

        [FieldFixedLength(1)]
        public string FuelType;
        
        [FieldFixedLength(10)]
        [FieldAlign(AlignMode.Right)]
        public string AmtGal;

        [FieldFixedLength(3)]
        public string Field11;

        [FieldFixedLength(6)]
        [FieldAlign(AlignMode.Right)]
        public string Odometer;

        [FieldFixedLength(27)]
        public string Field13;

        [FieldFixedLength(7)]
        [FieldAlign(AlignMode.Right)]
        public string TheirEmployeeNumber;

        [FieldFixedLength(27)]
        public string Field15;

        [FieldFixedLength(6)]
        [FieldAlign(AlignMode.Right)]
        public string DeviceNo;

        [FieldFixedLength(6)]
        public string Field17;

        [FieldFixedLength(3)]
        public string NonFuelAmount;

        [FieldFixedLength(9)]
        [FieldAlign(AlignMode.Right)]
        public string CustomerSalesAmount;

        [FieldFixedLength(9)]
        [FieldAlign(AlignMode.Right)]
        public string FullPrice;

        [FieldFixedLength(7)]
        [FieldAlign(AlignMode.Right)]
        public string SpragueName;
    }
}
