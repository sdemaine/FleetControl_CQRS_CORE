using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("SyncVehicle")]
    public class SyncVehicle : EntityBase
    {
        [DataMember]
        public int VehicleId { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Lock Code")]
        public string LockCode { get; set; }

        [DataMember]
        public DateTime? LockDate { get; set; }

        [DataMember]
        public int AccountNumber { get; set; }

        [DataMember]
        [Display(Name = "Date First Purchased")]
        [Column("Date1stPur")]
        public DateTime? DateFirstPurchased { get; set; }

        [DataMember]
        [Column("VIN")]
        [MaxLength(17)]
        public string VinNumber { get; set; }

        [DataMember]
        [Display(Name = "Vehicle License Tag")]
        [MaxLength(10)]
        public string VehicleLicenseTag { get; set; }

        [DataMember]
        [Display(Name = "Vehicle License Tag State")]
        [MaxLength(2)]
        public string VehicleLicenseTagState { get; set; }

        [DataMember]
        [Display(Name = "Vehicle Description")]
        [Column("VehDesc")]
        [MaxLength(25)]
        public string VehicleDescription { get; set; }

        [DataMember]
        [Display(Name = "Product Type 1")]
        [MaxLength(25)]
        public string ProductType1 { get; set; }

        [DataMember]
        [Display(Name = "Product 1 Capacity")]
        public int Product1Capacity { get; set; }

        [DataMember]
        [Display(Name = "Product Type 2")]
        [MaxLength(25)]
        public string ProductType2 { get; set; }

        [DataMember]
        [Display(Name = "Product 2 Capacity")]
        public int Product2Capacity { get; set; }

        [DataMember]
        [Display(Name = "Product Cap Percent Variance")]
        [Column("ProductCapPercentVar")]
        public int? ProductCapPercentVariance { get; set; }

        [DataMember]
        [Display(Name = "Mileage Units Per Gallon")]
        public int? MileageUnitsPerGallon { get; set; }

        [DataMember]
        [Display(Name = "Mileage Units of Measure")]
        [MaxLength(10)]
        public string MileageUnitsOfMeasure { get; set; }

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
        public decimal? MaxGallonsPerCycle { get; set; }

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
        public decimal? LastGallonAmount { get; set; }

        [DataMember]
        [Display(Name = "Their Vehicle Number")]
        [MaxLength(20)]
        public string TheirVehicleNumber { get; set; }

        [DataMember]
        [Display(Name = "Vehicle Type")]
        [MaxLength(2)]
        public string VehicleType { get; set; }

        [DataMember]
        [Display(Name = "Used On Road")]
        [MaxLength(1)]
        public string UsedOnRoad { get; set; }

        [DataMember]
        [Display(Name = "Vehicle Level 2 Id")]
        public int VehicleLevel2Id { get; set; }

        [DataMember]
        [Display(Name = "Vehicle Level 3 Id")]
        public int VehicleLevel3Id { get; set; }

        [DataMember]
        [Display(Name = "Vehicle Level 4 Id")]
        public int VehicleLevel4Id { get; set; }

        [DataMember]
        [Display(Name = "Vehicle Level 5 Id")]
        public int VehicleLevel5Id { get; set; }

        [DataMember]
        [Display(Name = "Vehicle Level 6 Id")]
        public int VehicleLevel6Id { get; set; }

        [DataMember]
        [Display(Name = "Vehicle Level 7 Id")]
        public int VehicleLevel7Id { get; set; }

        [DataMember]
        [MaxLength(13)]
        [Display(Name = "Vehicle User Code 1")]
        public string VehicleUserCode1 { get; set; }

        [DataMember]
        [Display(Name = "Vehicle User Code 2")]
        [MaxLength(10)]
        public string VehicleUserCode2 { get; set; }

        [MaxLength(8)]
        [DataMember]
        [Display(Name = "Vehicle User Code 3")]
        public string VehicleUserCode3 { get; set; }

        [DataMember]
        [Display(Name = "Vehicle User Code 4")]
        [MaxLength(8)]
        public string VehicleUserCode4 { get; set; }

        [DataMember]
        [MaxLength(8)]
        [Display(Name = "Vehicle User Code 5")]
        public string VehicleUserCode5 { get; set; }

        [DataMember]
        [Display(Name = "Class")]
        [MaxLength(10)]
        public string Class { get; set; }

        [DataMember]
        [Display(Name = "Odometer")]
        public int? Odometer { get; set; }

        [DataMember]
        [Display(Name = "External Pin")]
        [MaxLength(10)]
        public string ExternalPin { get; set; }

        [DataMember]
        public int Pin { get; set; }

        [DataMember]
        [Display(Name = "Sequence")]
        public int Sequence { get; set; }

        [DataMember]
        [Display(Name = "Status")]
        public StatusMode Status { get; set; }

        [DataMember]
        [Display(Name = "Last Use Date")]
        public DateTime? LastUseDate { get; set; }

        [DataMember]
        [Display(Name = "Use Count")]
        public int? UseCount { get; set; }

        [DataMember]
        [Display(Name = "MeterType")]
        [MaxLength(12)]
        public string MeterType { get; set; }

        [DataMember]
        [Display(Name = "Quantity")]
        [Column("Qty")]
        public decimal? Quantity { get; set; }

        [DataMember]
        [Display(Name = "Last Odometer")]
        public DateTime? LastOdometer { get; set; }

        [DataMember]
        public int CustomerId { get; set; }
    }
}
