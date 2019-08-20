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
    public class DAMCardObject
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

        [FieldFixedLength(9)]
        public string AccountId;

        [FieldFixedLength(19)]
        public string XrefId;

        [FieldFixedLength(1)]
        public string ActionCode;

        [FieldFixedLength(5)]
        public string CardId;

        [FieldFixedLength(1)]
        public string CardStatusIndicator;

        [FieldFixedLength(1)]
        public string CardHoldIndicator;

        [FieldFixedLength(1)]
        public string TranIdType;

        [FieldFixedLength(6)]
        public string TranIdNumber;

        [FieldFixedLength(1)]
        public string PromptIdType;

        [FieldFixedLength(6)]
        public string PinNumber;

        [FieldFixedLength(2)]
        public string RestrictionCode;

        [FieldFixedLength(25)]
        public string EmbossLine1;

        [FieldFixedLength(25)]
        public string EmbossLine2;

        [FieldFixedLength(17)]
        public string EmbossLine3;

        [FieldFixedLength(4)]
        public string MonthlyTransactionLimit_Legacy;   // Monthly Transaction Limit

        [FieldFixedLength(1)]
        public string MonthlyTransactionLimit_LegacyMode;   // Monthly Transaction Limit Mode

        [FieldFixedLength(7)]
        public string BillingPeriodDollarLimit;

        [FieldFixedLength(4)]
        public string DailyTransactionLimit;

        [FieldFixedLength(1)]
        public string BillingPeriodDollarLimitMode;

        [FieldFixedLength(1)]
        public string DailyTransactionLimitMode;

        [FieldFixedLength(6)]
        public string AddressId;

        [FieldFixedLength(13)]
        public string UserCode1;

        [FieldFixedLength(10)]
        public string UserCode2;

        [FieldFixedLength(8)]
        public string UserCode3;

        [FieldFixedLength(8)]
        public string UserCode4;

        [FieldFixedLength(8)]
        public string UserCode5;

        [FieldFixedLength(9)]
        public string OrgLevel2;

        [FieldFixedLength(9)]
        public string OrgLevel3;

        [FieldFixedLength(9)]
        public string OrgLevel4;

        [FieldFixedLength(9)]
        public string OrgLevel5;

        [FieldFixedLength(102)]
        public string Filler1;

        [FieldFixedLength(9)]
        public string OrgLevel6;

        [FieldFixedLength(9)]
        public string OrgLevel7;

        [FieldFixedLength(32)]
        public string Filler2;

        [FieldFixedLength(9)]
        public string DailyDollarLimit;

        [FieldFixedLength(1)]
        public string DailyDollarLimitMode;

        [FieldFixedLength(3)]
        public string WeeklyTransactionLimit;

        [FieldFixedLength(1)]
        public string WeeklyTransactionLimitMode;

        [FieldFixedLength(9)]
        public string WeeklyDollarLimit;

        [FieldFixedLength(1)]
        public string WeeklyDollarLimitMode;

        [FieldFixedLength(4)]
        public string MonthlyTransactionLimit;

        [FieldFixedLength(1)]
        public string MonthlyTransactionLimitMode;

        [FieldFixedLength(9)]
        public string MonthlyDollarLimit;

        [FieldFixedLength(1)]
        public string MonthlyDollarLimitMode;

        [FieldFixedLength(9)]
        public string TransactionDollarLimit;

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

        [FieldFixedLength(1)]
        public string OdometerValidation;

        [FieldFixedLength(4)]
        public string OdometerLimit;

        [FieldFixedLength(1)]
        public string OdometerValidationMode;

        [FieldFixedLength(109)]
        public string Filler3;

    }
}
