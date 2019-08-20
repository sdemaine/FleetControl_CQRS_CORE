using FleetControl.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Cards
{
    public class GetFleetCard_ViewDto
    {
        public string LockCode { get; set; }

        public DateTime? LockDate { get; set; }

        public string ExternalCardId { get; set; }

        public int AccountNumber { get; set; }  // is this the same as the VoyagerAccount number from the TranDetail ?

        public CardType CardType { get; set; }

        public int? CardNo { get; set; } //.. External Card Number

        public string TheirCardNumber { get; set; }

        public string EmbossedCardNumber { get; set; }

        public EmbossingElement EmbossingElement1 { get; set; }

        public EmbossingElement EmbossingElement2 { get; set; }

        public EmbossingElement EmbossingElement3 { get; set; }

        public string EmbossLine1 { get; set; }

        public string EmbossLine2 { get; set; }

        public string EmbossLine3 { get; set; }

        public CardEntityType CardEntityType { get; set; }

        public DateTime? Date1stPur { get; set; }    //.. Date of 1st Purchase

        public decimal? MaxGallonsPerTransaction { get; set; }

        public decimal? MaxGallonsPerDay { get; set; }

        public decimal? MaxGallonsPerBillingCycle { get; set; }

        public decimal? MaxMotorOilDollars { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public decimal? LastGallonsAmount { get; set; }

        public int CardLevel2Id { get; set; }

        public int? CardLevel3Id { get; set; }

        public int? CardLevel4Id { get; set; }

        public int? CardLevel5Id { get; set; }

        public int? CardLevel6Id { get; set; }

        public int? CardLevel7Id { get; set; }

        public string CardUserCode1 { get; set; }

        public string CardUserCode2 { get; set; }

        public string CardUserCode3 { get; set; }

        public string CardUserCode4 { get; set; }

        public string CardUserCode5 { get; set; }

        public ProductUse ProductUse { get; set; }    //.. FuelOnly = 0,  Other = 1

        public int? TransactionDollarLimit { get; set; }

        public HardSoftModes TransactionDollarLimitMode { get; set; }

        public int? DailyDollarLimit { get; set; }   //.. Maximum amount of dollars spent per day for card; NULL not used

        public HardSoftModes DailyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        public int? WeeklyDollarLimit { get; set; }

        public HardSoftModes WeeklyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        public int? MonthlyDollarLimit { get; set; }

        public HardSoftModes MonthlyDollarLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        public int? DailyTransactionLimit { get; set; }

        public HardSoftModes DailyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        public int? WeeklyTransactionLimit { get; set; }

        public HardSoftModes WeeklyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        public int? MonthlyTransactionLimit { get; set; }

        public HardSoftModes MonthlyTransactionLimitMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        public PurchaseDayEnum PurchaseDay { get; set; }    //.. 01 = All, 02 = Mon-Fri, 03 = Sat, 04 = Sun, 05 = Mon-Sat, 06 = Mon-Fri & Sat, 07 = Sat & Sun

        public HardSoftExceptionModes PurchaseDayMode { get; set; }  //.. 0 = soft limit, 1 = hard limit (no transaction allowed)

        public DateTime? PurchaseFromTimeBand1 { get; set; }

        public DateTime? PurchaseToTimeBand1 { get; set; }

        public HardSoftExceptionModes? PurchaseTimeBand1Mode { get; set; } //.. 0 = soft limit, 1 = hard limit (no transaction allowed), 2 = Exception reporting

        public DateTime? PurchaseFromTimeBand2 { get; set; }

        public DateTime? PurchaseToTimeBand2 { get; set; }

        public HardSoftExceptionModes? PurchaseTimeBand2Mode { get; set; } //.. 0 = soft limit, 1 = hard limit (no transaction allowed), 2 = Exception reporting

        public BooleanEnum OdometerValidation { get; set; }

        public int? OdometerLimit { get; set; }

        public HardSoftModes OdometerValidationMode { get; set; }

        public StatusMode Status { get; set; }

        public DateTime? LastUseDate { get; set; }   //.. Date of last transaction

        public int? UseCount { get; set; }   //.. Count of transactions for this card

        public decimal? Quantity { get; set; }    //.. Sum of gallons to date of transactions by this vehicle record

        public DateTime? LastOdometer { get; set; }  //.. NBCS date of last odometer reading, currently not used             

        public int? DriverId { get; set; }

        public virtual DriverDto Driver { get; set; }

        public int? VehicleId { get; set; }

        public virtual VehicleDto Vehicle { get; set; }

        public DateTime? CardExpirationDate { get; set; }

        public int CustomerId { get; set; }

        public virtual CustomerDto Customer { get; set; }

        public CardStatusIndicator DAMCardStatusIndicator { get; set; }

        public CardPromptPattern CardPromptPattern { get; set; }

        public int? PinNumber { get; set; }

        public int? CardAddressId { get; set; }

        public CardRestrictionCode RestrictionCode { get; set; }

        public BooleanEnum Synchronized { get; set; }

        public bool? SubmitPending { get; set; }

        public int? ClassId { get; set; }

        public int? CardClassId { get; set; }

        public virtual CardClassDto Class { get; set; }

        public bool IsConsignment { get; set; }

        public int FormerVehicleId { get; set; }

        public int FormerDriverId { get; set; }

        public DateTime? ExternalDeleteDate { get; set; }

        public bool IsFuelMaster { get; set; }

        public bool IsWinC6 { get; set; }

        public bool IsVoyager { get; set; }

        public bool ExistsInVoyager { get; set; }
    }
}
