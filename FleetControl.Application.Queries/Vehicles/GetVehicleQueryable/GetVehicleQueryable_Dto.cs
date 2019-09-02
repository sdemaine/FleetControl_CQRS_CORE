using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Vehicles
{
    public class GetVehicleQueryable_Dto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string LockCode { get; set; }

        public DateTime? LockDate { get; set; }

        public int AccountNumber { get; set; }

        public DateTime? DateFirstPurchased { get; set; }

        public string VinNumber { get; set; }

        public string VehicleLicenseTag { get; set; }

        public string VehicleLicenseTagState { get; set; }

        public string ExternalVehicleId { get; set; }

        public string VehicleDescription { get; set; }

        public int? ProductType1 { get; set; }

        public int Product1Capacity { get; set; }

        public int? ProductType2 { get; set; }

        public int Product2Capacity { get; set; }

        public int? ProductCapPercentVariance { get; set; }

        public int? MileageUnitsPerGallon { get; set; }

        public string MileageUnitsOfMeasure { get; set; }

        public decimal? MaxGallonsPerTransaction { get; set; }

        public decimal? MaxGallonsPerDay { get; set; }

        public decimal? MaxGallonsPerCycle { get; set; }

        public decimal? MaxMotorOilDollars { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public decimal? LastGallonAmount { get; set; }

        public string TheirVehicleNumber { get; set; }

        public string VehicleType { get; set; }

        public string UsedOnRoad { get; set; }

        public int VehicleLevel2Id { get; set; }

        public int? VehicleLevel3Id { get; set; }

        public int? VehicleLevel4Id { get; set; }

        public int? VehicleLevel5Id { get; set; }

        public int? VehicleLevel6Id { get; set; }

        public int? VehicleLevel7Id { get; set; }

        public string VehicleUserCode1 { get; set; }

        public string VehicleUserCode2 { get; set; }

        public string VehicleUserCode3 { get; set; }

        public string VehicleUserCode4 { get; set; }

        public string VehicleUserCode5 { get; set; }

        public string Class { get; set; }

        public int? Odometer { get; set; }

        public string ExternalPin { get; set; }

        public int Pin { get; set; }

        public int Sequence { get; set; }

        public StatusMode Status { get; set; }

        public DateTime? LastUseDate { get; set; }

        public int? UseCount { get; set; }

        public string MeterType { get; set; }

        public decimal? Quantity { get; set; }

        public DateTime? LastOdometer { get; set; }


        public virtual Customer Customer { get; set; }

        public BooleanEnum Synchronized { get; set; }

        public string LegacyProductCode1 { get; set; }

        public string LegacyProductCode2 { get; set; }

        public bool? SubmitPending { get; set; }

        public int? ClassId { get; set; }

        public DateTime? ExternalDeleteDate { get; set; }

        public bool IsFuelMaster { get; set; }

        public bool IsConsignment { get; set; }

        public bool IsWinC6 { get; set; }

        public bool IsVoyager { get; set; }

        public bool ExistsInVoyager { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Vehicle, GetVehicleQueryable_Dto>()
                ;
        }
    }
}
