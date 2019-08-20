using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("DAMCardConfirmation")]
    public class DAMCardConfirmation : EntityBase
    {
        [DataMember]
        [MaxLength(1)]
        public string LockCode { get; set; }

        [DataMember]
        public DateTime? LockDate { get; set; }

        [DataMember]
        public int ExternalCardId { get; set; }

        [DataMember]
        public int AccountNumber { get; set; }  // is this the same as the VoyagerAccount number from the TranDetail ?

        [DataMember]
        public int? CardNo { get; set; } //.. External Card Number

        [DataMember]
        public string TheirCardNumber { get; set; }

        [DataMember]
        [Column("EntityType")]
        public CardEntityType CardEntityType { get; set; }

        [DataMember]
        public DateTime? Date1stPur { get; set; }    //.. Date of 1st Purchase

        [DataMember]
        [Column("MaxGalTrn")]
        public decimal? MaxGallonsPerTransaction { get; set; }

        [DataMember]
        [Column("MaxGalDay")]
        public decimal? MaxGallonsPerDay { get; set; }

        [DataMember]
        [Column("MaxGalCycl")]
        public decimal? MaxGallonsPerBillingCycle { get; set; }

        [DataMember]
        [Column("MaxMotorOil")]
        public decimal? MaxMotorOilDollars { get; set; }

        [DataMember]
        public DateTime? LastActivityDate { get; set; }

        [DataMember]
        [Column("LastGallons")]
        public decimal? LastGallonsAmount { get; set; }

        [DataMember]
        public int BAID { get; set; }

        [DataMember]
        public int CardLevel2Id { get; set; }

        [DataMember]
        public int? CardLevel3Id { get; set; }

        [DataMember]
        public int? CardLevel4Id { get; set; }

        [DataMember]
        public int? CardLevel5Id { get; set; }

        [DataMember]
        public int? CardLevel6Id { get; set; }

        [DataMember]
        public int? CardLevel7Id { get; set; }

        [DataMember]
        [MaxLength(13)]
        public string CardUserCode1 { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string CardUserCode2 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string CardUserCode3 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string CardUserCode4 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string CardUserCode5 { get; set; }

        [DataMember]
        public ProductUse ProductUse { get; set; }    //.. FuelOnly = 0,  Other = 1

        [DataMember]
        public int? DailyDollarLimit { get; set; }   //.. Maximum amount of dollars spent per day for card; NULL not used

        [DataMember]
        public HardSoftModes? DailyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        public int? WeeklyDollarLimit { get; set; }

        [DataMember]
        public HardSoftModes? WeeklyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        public int? MonthlyDollarLimit { get; set; }

        [DataMember]
        public HardSoftModes? MonthlyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        public int? DailyTransactionLimit { get; set; }

        [DataMember]
        public HardSoftModes? DailyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        public int? WeeklyTransactionLimit { get; set; }

        [DataMember]
        public HardSoftModes? WeeklyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        public int? MonthlyTransactionLimit { get; set; }

        [DataMember]
        public HardSoftModes? MonthlyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        public PurchaseDayEnum? PurchaseDay { get; set; }    //.. 01 = All, 02 = Mon-Fri, 03 = Sat, 04 = Sun, 05 = Mon-Sat, 06 = Mon-Fri & Sat, 07 = Sat & Sun

        [DataMember]
        public HardSoftExceptionModes? PurchaseDayMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        [DataType(DataType.Time)]
        public DateTime? PurchaseFromTimeBand1 { get; set; }

        [DataMember]
        [DataType(DataType.Time)]
        public DateTime? PurchaseToTimeBand1 { get; set; }

        [DataMember]
        public HardSoftExceptionModes? PurchaseDayBand1Mode { get; set; } //.. 0 = soft limit, 1 = hard limit (no transaction allowed), 2 = Exception reporting

        [DataMember]
        [DataType(DataType.Time)]
        public DateTime? PurchaseFromTimeBand2 { get; set; }

        [DataMember]
        [DataType(DataType.Time)]
        public DateTime? PurchaseToTimeBand2 { get; set; }

        [DataMember]
        public HardSoftExceptionModes? PurchaseDayBand2Mode { get; set; } //.. 0 = soft limit, 1 = hard limit (no transaction allowed), 2 = Exception reporting

        [DataMember]
        public BooleanEnum OdometerValidation { get; set; }

        [DataMember]
        public HardSoftModes OdometerValidationMode { get; set; }

        [DataMember]
        public int OdometerLimit { get; set; }

        [DataMember]
        public StatusMode Status { get; set; }

        [DataMember]
        public DateTime? LastUseDate { get; set; }   //.. Date of last transaction

        [DataMember]
        public int? UseCount { get; set; }   //.. Count of transactions for this card

        [DataMember]
        [Column("QTY")]
        public decimal? Quantity { get; set; }    //.. Sum of gallons to date of transactions by this vehicle record

        [DataMember]
        public DateTime? LastOdometer { get; set; }  //.. NBCS date of last odometer reading, currently not used             

        [DataMember]
        public int? DriverId { get; set; }

        [DataMember]
        public int? VehicleId { get; set; }

        [DataMember]
        public DateTime? CardExpirationDate { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public CardStatusIndicator CardStatusIndicator { get; set; }

        [DataMember]
        [MaxLength(5)]
        public string ErrorCode1 { get; set; }

        [DataMember]
        [MaxLength(5)]
        public string ErrorCode2 { get; set; }

        [DataMember]
        [MaxLength(5)]
        public string ErrorCode3 { get; set; }

        [DataMember]
        [MaxLength(5)]
        public string ErrorCode4 { get; set; }

        [DataMember]
        [MaxLength(5)]
        public string ErrorCode5 { get; set; }
    }
}
