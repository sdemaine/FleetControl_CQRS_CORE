using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("VoyagerCard")]
    public class VoyagerCard : EntityBase
    {
        [DataMember]
        public int AccountNumber { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public int CardId { get; set; }

        [DataMember]
        public StatusMode Status { get; set; }

        [DataMember]
        public DateTime? StatusDate { get; set; }

        [DataMember]
        public bool IsLocked { get; set; }

        [DataMember]
        public int CardTie { get; set; }

        [DataMember]
        public CardPromptPattern PromptType { get; set; }

        [DataMember]
        public CardRestrictionCode RestrictionCode { get; set; }

        [DataMember]
        public int TransactionDollarLimit { get; set; }

        [DataMember]
        public HardSoftModes TransactionDollarLimitMode { get; set; }

        [DataMember]
        public int DailyTransactionLimit { get; set; }

        [DataMember]
        public HardSoftModes DailyTransactionLimitMode { get; set; }

        [DataMember]
        public int WeeklyTransactionLimit { get; set; }

        [DataMember]
        public HardSoftModes WeeklyTransactionLimitMode { get; set; }

        [DataMember]
        public int MonthlyTransactionLimit { get; set; }

        [DataMember]
        public HardSoftModes MonthlyTransactionLimitMode { get; set; }

        [DataMember]
        public int DailyDollarLimit { get; set; }

        [DataMember]
        public HardSoftModes DailyDollarLimitMode { get; set; }

        [DataMember]
        public int WeeklyDollarLimit { get; set; }

        [DataMember]
        public HardSoftModes WeeklyDollarLimitMode { get; set; }

        [DataMember]
        public int MonthlyDollarLimit { get; set; }

        [DataMember]
        public HardSoftModes MonthlyDollarLimitMode { get; set; }

        [DataMember]
        public int PIN { get; set; }

        [DataMember]
        public string CardEmbossLine1 { get; set; }

        [DataMember]
        public string CardEmbossLine2 { get; set; }

        [DataMember]
        public string CardEmbossLine3 { get; set; }

        [DataMember]
        public string NameEmbossed { get; set; }

        [DataMember]
        public string EmbossedCardNumber { get; set; }

        [DataMember]
        public string Address1 { get; set; }

        [DataMember]
        public string Address2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string UserCode1 { get; set; }

        [DataMember]
        public string UserCode2 { get; set; }

        [DataMember]
        public string UserCode3 { get; set; }

        [DataMember]
        public string UserCode4 { get; set; }

        [DataMember]
        public string UserCode5 { get; set; }

        [DataMember]
        public DateTime? PurchaseFromTimeband1 { get; set; }

        [DataMember]
        public DateTime? PurchaseToTimeBand1 { get; set; }

        [DataMember]
        public HardSoftExceptionModes PurchaseTimeBand1Mode { get; set; }

        [DataMember]
        public DateTime? PurchaseFromTimeBand2 { get; set; }

        [DataMember]
        public DateTime? PurchaseToTimeBand2 { get; set; }

        [DataMember]
        public HardSoftExceptionModes PurchaseTimeBand2Mode { get; set; }

        [DataMember]
        public PurchaseDayEnum PurchaseDay { get; set; }

        [DataMember]
        public HardSoftExceptionModes PurchaseDayMode { get; set; }

        [DataMember]
        public CardTiedToEntity DriverVehicleType { get; set; }

        [DataMember]
        public int DriverId { get; set; }

        [DataMember]
        public string DriverFirstName { get; set; }

        [DataMember]
        public string DriverLastName { get; set; }

        [DataMember]
        public string DriverMiddleInitial { get; set; }

        [DataMember]
        public DateTime? DriverStatusDate { get; set; }

        [DataMember]
        public StatusMode? DriverStatus { get; set; }

        [DataMember]
        public int VehicleId { get; set; }

        [DataMember]
        public StatusMode? VehicleStatus { get; set; }

        [DataMember]
        public DateTime? VehicleStatusDate { get; set; }

        [DataMember]
        public string VinNumber { get; set; }

        [DataMember]
        public string VehicleDescription { get; set; }

        [DataMember]
        public string LicenseNumber { get; set; }

        [DataMember]
        public string LicenseState { get; set; }

        [DataMember]
        public string OrgLevel2Name { get; set; }

        [DataMember]
        public string OrgLevel3Name { get; set; }

        [DataMember]
        public string OrgLevel4Name { get; set; }

        [DataMember]
        public string OrgLevel5Name { get; set; }

        [DataMember]
        public string OrgLevel6Name { get; set; }

        [DataMember]
        public string OrgLevel7Name { get; set; }

        [DataMember]
        public int OrgLevel2Id { get; set; }

        [DataMember]
        public int OrgLevel3Id { get; set; }

        [DataMember]
        public int OrgLevel4Id { get; set; }

        [DataMember]
        public int OrgLevel5Id { get; set; }

        [DataMember]
        public int OrgLevel6Id { get; set; }

        [DataMember]
        public int OrgLevel7Id { get; set; }
    }
}
