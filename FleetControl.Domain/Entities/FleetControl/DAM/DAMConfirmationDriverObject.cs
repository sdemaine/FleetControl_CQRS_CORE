using FileHelpers;
using FleetControl.Domain;
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
    public class DAMConfirmationDriverObject
    {
        #region Member Variables & Properties

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

        [FieldFixedLength(1)]
        public string ActionCode;

        [FieldFixedLength(6)]
        public string DriverId;

        [FieldFixedLength(12)]
        public string LastName;

        [FieldFixedLength(11)]
        public string FirstName;

        [FieldFixedLength(1)]
        public string MiddleInitial;

        [FieldFixedLength(1)]
        public string Status;

        [FieldFixedLength(20)]
        public string UserReserve;

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

        [FieldFixedLength(9)]
        public string OrgLevel6;

        [FieldFixedLength(9)]
        public string OrgLevel7;

        [FieldFixedLength(82)]
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

        [FieldFixedLength(100)]
        public string Filler2;

        [FieldFixedLength(4)]
        public string BillingPeriodTransactionLimit;

        [FieldFixedLength(1)]
        public string BillingPeriodTransactionLimitMode;

        [FieldFixedLength(9)]
        public string BillingPeriodDollarLimit;

        [FieldFixedLength(1)]
        public string BillingPeriodDollarLimitMode;

        [FieldFixedLength(2)]
        public string DailyTransactionLimit;

        [FieldFixedLength(1)]
        public string DailyTransactionLimitMode;

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
        public string PurchaseDayBand1Mode;

        [FieldFixedLength(8)]
        public string PurchaseFromTimeBand2;

        [FieldFixedLength(8)]
        public string PurchaseToTimeBand2;

        [FieldFixedLength(97)]
        public string Filler3;

        #endregion

        static DAMConfirmationDriverObject()
        {
            AutoMapper.Mapper.CreateMap<DAMConfirmationDriverObject, Driver>();
        }

        public static Driver FromDriverDTO(DAMConfirmationDriverObject damConfirmationDriverObject, Driver driver)
        {
            if (driver == null)
            {
                driver = new Driver();
            }
            AutoMapper.Mapper.Map<DAMConfirmationDriverObject, Driver>(damConfirmationDriverObject, driver);
            return driver;
        }
    }
}
