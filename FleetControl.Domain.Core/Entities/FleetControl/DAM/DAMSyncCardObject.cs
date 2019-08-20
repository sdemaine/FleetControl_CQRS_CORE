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
    public class DAMSyncCardObject
    {
        [FieldFixedLength(1)]
        public string RecordType;

        [FieldFixedLength(15)]
        public string AcccountCardId;

        [FieldFixedLength(1)]
        public string Tie;

        [FieldFixedLength(6)]
        public string TieVehicleDriverId;

        [FieldFixedLength(4)]
        public string ExpirationDate;

        [FieldFixedLength(6)]
        public int? PinNumber;

        [FieldFixedLength(25)]
        public string OrgLevel2Name;

        [FieldFixedLength(25)]
        public string OrgLevel3Name;

        [FieldFixedLength(1)]
        public string StatusCurrent;

        [FieldFixedLength(8)]
        public string StatusCurrentDate;

        [FieldFixedLength(48)]
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
        public string CardUserCode1;

        [FieldFixedLength(10)]
        public string CardUserCode2;

        [FieldFixedLength(8)]
        public string CardUserCode3;

        [FieldFixedLength(8)]
        public string CardUserCode4;

        [FieldFixedLength(8)]
        public string CardUserCode5;

        [FieldFixedLength(4)]
        public int? BillingPeriodTransactionLimit;

        [FieldFixedLength(1)]
        public string BillingPeriodTransactionLimitMode;

        [FieldFixedLength(7)]
        public int? BillingPeriodDollarLimit;

        [FieldFixedLength(4)]
        public int? DailyTransactionLimit;

        [FieldFixedLength(1)]
        public string BillingPeriodDollarLimitMode;

        [FieldFixedLength(1)]
        public string DailyTransactionLimitMode;

        [FieldFixedLength(9)]
        public string Filler2;

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
        public int? TransactionDollarLimit;

        [FieldFixedLength(1)]
        public string TransactionDollarLimitMode;

        [FieldFixedLength(2)]
        public string PurchaseDay;

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

        [FieldFixedLength(4)]
        public string PromptErrorCount;

        [FieldFixedLength(1)]
        public string OdometerValidation;

        [FieldFixedLength(4)]
        public int? OdometerLimit;

        [FieldFixedLength(1)]
        public string OdometerValidationMode;

        [FieldFixedLength(80)]
        public string Filler3;

    }
}
