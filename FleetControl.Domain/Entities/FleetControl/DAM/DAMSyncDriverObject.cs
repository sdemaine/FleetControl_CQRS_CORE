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
    public class DAMSyncDriverObject
    {
        [FieldFixedLength(1)]
        public string RecordType;

        [FieldFixedLength(9)]
        public int? AccountId;

        [FieldFixedLength(6)]
        public int? DriverId;

        [FieldFixedLength(5)]
        public int? TieCardId;

        [FieldFixedLength(12)]
        public string LastName;

        [FieldFixedLength(11)]
        public string FirstName;

        [FieldFixedLength(1)]
        public string MiddleInitial;

        [FieldFixedLength(25)]
        public string OrgLevel2Name;

        [FieldFixedLength(25)]
        public string OrgLevel3Name;

        [FieldFixedLength(45)]
        public string Filler1;

        [FieldFixedLength(25)]
        public string OrgLevel4Name;

        [FieldFixedLength(25)]
        public string OrgLevel5Name;

        [FieldFixedLength(25)]
        public string OrgLevel6Name;

        [FieldFixedLength(25)]
        public string OrgLevel7Name;

        [FieldFixedLength(13)]
        public string DriverUserCode1;

        [FieldFixedLength(10)]
        public string DriverUserCode2;

        [FieldFixedLength(8)]
        public string DriverUserCode3;

        [FieldFixedLength(8)]
        public string DriverUserCode4;

        [FieldFixedLength(8)]
        public string DriverUserCode5;

        [FieldFixedLength(1)]
        public string Status;

        [FieldFixedLength(8)]
        public string StatusDate;

        [FieldFixedLength(18)]
        public string Filler2;

        [FieldFixedLength(9)]
        public int? BillingPeriodTransactionLimit;

        [FieldFixedLength(1)]
        public string BillingPeriodTransactionLimitMode;

        [FieldFixedLength(9)]
        public int? BillingPeriodDollarLimit;

        [FieldFixedLength(1)]
        public string BillingPeriodDollarLimitMode;

        [FieldFixedLength(9)]
        public int? DailiyTransactionLimit;

        [FieldFixedLength(1)]
        public string DailyTransactionLimitMode;

        [FieldFixedLength(9)]
        public int? DailyDollarLimit;

        [FieldFixedLength(1)]
        public string DailyDollarLimitMode;

        [FieldFixedLength(9)]
        public int? WeeklyTransactionLimit;

        [FieldFixedLength(1)]
        public string WeeklyTransactionLimitMode;

        [FieldFixedLength(9)]
        public int? WeeklyDollarLimit;

        [FieldFixedLength(1)]
        public string WeeklyDollarLimitMode;

        [FieldFixedLength(9)]
        public int? MonthlyTransactionLimit;

        [FieldFixedLength(1)]
        public string MonthlyTransactionLimitMode;

        [FieldFixedLength(9)]
        public int? MonthlyDollarLimit;

        [FieldFixedLength(1)]
        public string MonthlyDollarLimitMode;

        [FieldFixedLength(9)]
        public int? InvoiceDollarLimit;

        [FieldFixedLength(1)]
        public string InvoiceDollarLimitMode;

        [FieldFixedLength(2)]
        public int? PurchaseDay;

        [FieldFixedLength(1)]
        public string PurchaseDayMode;

        [FieldFixedLength(8)]
        public string PurchaseFromTimeBand1;

        [FieldFixedLength(8)]
        public string PurchaseToTimeBand1;

        [FieldFixedLength(1)]
        public string PurchaseTimeBand1Mode;

        [FieldFixedLength(8)]
        public string PurchaseFromTimeBand2;

        [FieldFixedLength(8)]
        public string PurchaseToTimeBand2;

        [FieldFixedLength(60)]
        public string Filler3;
    }
}
