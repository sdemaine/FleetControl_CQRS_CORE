using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("SyncCard")]
    public class SyncCard : EntityBase
    {
        [DataMember]
        public int CardId { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Lock Code")]
        public string LockCode { get; set; }

        [DataMember]
        public DateTime? LockDate { get; set; }

        [DataMember]
        [Display(Name = "External Card #")]
        public int ExternalCardId { get; set; }

        [DataMember]
        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }  // is this the same as the VoyagerAccount number from the TranDetail ?

        [DataMember]
        [Display(Name = "Card Number")]
        public int? CardNo { get; set; } //.. External Card Number

        [DataMember]
        [Display(Name = "Their Card #")]
        public string TheirCardNumber { get; set; }

        [DataMember]
        [Display(Name = "Entity Type")]
        [Column("EntityType")]
        public CardEntityType CardEntityType { get; set; }

        [DataMember]
        [Display(Name = "Date First Purchase")]
        public DateTime? Date1stPur { get; set; }    //.. Date of 1st Purchase

        [DataMember]
        [Display(Name = "Max Gallons Per Transaction")]
        [Column("MaxGalTrn")]
        public decimal? MaxGallonsPerTransaction { get; set; }

        [DataMember]
        [Display(Name = "Max Gallons Per Day")]
        [Column("MaxGalDay")]
        public decimal? MaxGallonsPerDay { get; set; }

        [DataMember]
        [Display(Name = "Max Gallons Per Cycle")]
        [Column("MaxGalCycl")]
        public decimal? MaxGallonsPerBillingCycle { get; set; }

        [DataMember]
        [Display(Name = "Max Motor Oil Dollars")]
        [Column("MaxMotorOil")]
        public decimal? MaxMotorOilDollars { get; set; }

        [DataMember]
        [Display(Name = "Last Activity Date")]
        public DateTime? LastActivityDate { get; set; }

        [DataMember]
        [Display(Name = "Last Gallon Amount")]
        [Column("LastGallons")]
        public decimal? LastGallonsAmount { get; set; }

        [DataMember]
        [Display(Name = "Card Level Id 2")]
        public int CardLevel2Id { get; set; }

        [DataMember]
        [Display(Name = "Card Level Id 3")]
        public int? CardLevel3Id { get; set; }

        [DataMember]
        [Display(Name = "Card Level Id 4")]
        public int? CardLevel4Id { get; set; }

        [DataMember]
        [Display(Name = "Card Level Id 5")]
        public int? CardLevel5Id { get; set; }

        [DataMember]
        [Display(Name = "Card Level Id 6")]
        public int? CardLevel6Id { get; set; }

        [DataMember]
        [Display(Name = "Card Level Id 7")]
        public int? CardLevel7Id { get; set; }

        [DataMember]
        [MaxLength(13)]
        [Display(Name = "Card User Code 1")]
        public string CardUserCode1 { get; set; }

        [DataMember]
        [Display(Name = "Card User Code 2")]
        [MaxLength(10)]
        public string CardUserCode2 { get; set; }

        [DataMember]
        [Display(Name = "Card User Code 3")]
        [MaxLength(8)]
        public string CardUserCode3 { get; set; }

        [DataMember]
        [Display(Name = "Card User Code 4")]
        [MaxLength(8)]
        public string CardUserCode4 { get; set; }

        [DataMember]
        [Display(Name = "Card User Code 5")]
        [MaxLength(8)]
        public string CardUserCode5 { get; set; }

        [DataMember]
        [Display(Name = "Product Use")]
        public ProductUse ProductUse { get; set; }    //.. FuelOnly = 0,  Other = 1

        [DataMember]
        [Display(Name = "Transaction Dollar Limit")]
        public int? TransactionDollarLimit { get; set; }

        [DataMember]
        [Display(Name = "Transaction Dollar Limit Mode")]
        public HardSoftModes? TransactionDollarLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Daily Dollar Limit")]
        public int? DailyDollarLimit { get; set; }   //.. Maximum amount of dollars spent per day for card; NULL not used

        [DataMember]
        [Display(Name = "Daily Dollar Limit Mode")]
        public HardSoftModes? DailyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        [Display(Name = "Weekly Dollar Limit")]
        public int? WeeklyDollarLimit { get; set; }

        [DataMember]
        [Display(Name = "Weekly Dollar Limit Mode")]
        public HardSoftModes? WeeklyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        [Display(Name = "Monthly Dollar Limit")]
        public int? MonthlyDollarLimit { get; set; }

        [DataMember]
        [Display(Name = "Monthly Dollar Limit Mode")]
        public HardSoftModes? MonthlyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        [Display(Name = "Daily Transaction Limit")]
        public int? DailyTransactionLimit { get; set; }

        [DataMember]
        [Display(Name = "Daily Transaction Limit Mode")]
        public HardSoftModes? DailyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        [Display(Name = "Weekly Transaction Limit")]
        public int? WeeklyTransactionLimit { get; set; }

        [DataMember]
        [Display(Name = "Weekly Transaction Limit Mode")]
        public HardSoftModes? WeeklyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        [Display(Name = "Monthly Transaction Limit")]
        public int? MonthlyTransactionLimit { get; set; }

        [DataMember]
        [Display(Name = "Monthly Transaction Limit Mode")]
        public HardSoftModes? MonthlyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        [Display(Name = "Purchase Day")]
        public PurchaseDayEnum PurchaseDay { get; set; }    //.. 01 = All, 02 = Mon-Fri, 03 = Sat, 04 = Sun, 05 = Mon-Sat, 06 = Mon-Fri & Sat, 07 = Sat & Sun

        [DataMember]
        [Display(Name = "Purchase Day Mode")]
        public HardSoftExceptionModes? PurchaseDayMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        [DataMember]
        [Display(Name = "Purchase From Time Band 1")]
        [DataType(DataType.Time)]
        public DateTime? PurchaseFromTimeBand1 { get; set; }

        [DataMember]
        [Display(Name = "Purchase To Time Band 1")]
        [DataType(DataType.Time)]
        public DateTime? PurchaseToTimeBand1 { get; set; }

        [DataMember]
        [Display(Name = "Purchase Day Band 1 Mode")]
        public HardSoftExceptionModes? PurchaseDayBand1Mode { get; set; } //.. 0 = soft limit, 1 = hard limit (no transaction allowed), 2 = Exception reporting

        [DataMember]
        [Display(Name = "Purchase From Time Band 2")]
        [DataType(DataType.Time)]
        public DateTime? PurchaseFromTimeBand2 { get; set; }

        [DataMember]
        [Display(Name = "Purchase To Time Band 2")]
        [DataType(DataType.Time)]
        public DateTime? PurchaseToTimeBand2 { get; set; }

        [DataMember]
        [Display(Name = "Purchase Day Band 2 Mode")]
        public HardSoftExceptionModes? PurchaseDayBand2Mode { get; set; } //.. 0 = soft limit, 1 = hard limit (no transaction allowed), 2 = Exception reporting

        [DataMember]
        [Display(Name = "Odometer Validation")]
        public BooleanEnum OdometerValidation { get; set; }

        [DataMember]
        [Display(Name = "Odometer Limit")]
        public int? OdometerLimit { get; set; }

        [DataMember]
        [Display(Name = "Odometer Limit Mode")]
        public HardSoftModes? OdometerLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Last Use Date")]
        public DateTime? LastUseDate { get; set; }   //.. Date of last transaction

        [DataMember]
        [Display(Name = "Use Count")]
        public int? UseCount { get; set; }   //.. Count of transactions for this card

        [DataMember]
        [Display(Name = "Quantity")]
        [Column("QTY")]
        public decimal? Quantity { get; set; }    //.. Sum of gallons to date of transactions by this vehicle record

        [DataMember]
        [Display(Name = "Last Odometer")]
        public DateTime? LastOdometer { get; set; }  //.. NBCS date of last odometer reading, currently not used             

        [DataMember]
        [Display(Name = "Driver")]
        public int? DriverId { get; set; }

        [DataMember]
        public Driver Driver { get; set; }

        [DataMember]
        [Display(Name = "Vehicle")]
        public int? VehicleId { get; set; }

        [DataMember]
        public Vehicle Vehicle { get; set; }

        [DataMember]
        [Display(Name = "Card Expiration Date")]
        public DateTime? CardExpirationDate { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        [Display(Name = "Card Status Indicator")]
        public CardStatusIndicator CardStatusIndicator { get; set; }

        [DataMember]
        [Display(Name = "Card Prompt")]
        public CardPromptPattern CardPromptPattern { get; set; }

        [DataMember]
        [Display(Name = "Pin Number")]
        public int? PinNumber { get; set; }
    }
}
