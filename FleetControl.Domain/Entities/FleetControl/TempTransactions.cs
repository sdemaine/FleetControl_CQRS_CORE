using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("TempTransaction")]
    public class TempTransaction : EntityBase
    {
        [DataMember]
        public string RecordType { get; set; }

        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public int AccountLevel1Id { get; set; }

        [DataMember]
        public int DriverLevel2Id { get; set; }

        [DataMember]
        public int DriverLevel3Id { get; set; }

        [DataMember]
        public int DriverId { get; set; }

        [DataMember]
        public string DriverLastName { get; set; }

        [DataMember]
        public string DriverFirstName { get; set; }

        [DataMember]
        public string DriverMiddleInitial { get; set; }

        [DataMember]
        public int VehicleLevel2Id { get; set; }

        [DataMember]
        public int VehicleLevel3Id { get; set; }

        [DataMember]
        public int VehicleId { get; set; }

        [DataMember]
        public string VehicleVinNumber { get; set; }

        [DataMember]
        public string VehicleDescription { get; set; }

        [DataMember]
        public string VehicleLicenseTag { get; set; }

        [DataMember]
        public string VehicleLicenseTagState { get; set; }

        [DataMember]
        public int CardLevel2Id { get; set; }

        [DataMember]
        public int CardLevel3Id { get; set; }

        [DataMember]
        public int CardId { get; set; }

        [DataMember]
        public int ParticipantCode { get; set; }

        [DataMember]
        public string PurchaseDate { get; set; }

        [DataMember]
        public int PurchaseTime { get; set; }

        [DataMember]
        public string InvoiceNumber { get; set; }

        [DataMember]
        public string MerchantAccountNumber { get; set; }

        [DataMember]
        public string MerchantAddress { get; set; }

        [DataMember]
        public string MerchantCity { get; set; }

        [DataMember]
        public string MerchantState { get; set; }

        [DataMember]
        public string MerchantZipCode { get; set; }

        [DataMember]
        public string MerchantZipCode4 { get; set; }

        [DataMember]
        public string ProductCode { get; set; }

        [DataMember]
        public Decimal ProductAmount { get; set; }

        [DataMember]
        public Decimal ProductUnits { get; set; }

        [DataMember]
        public Decimal CostPerUnit { get; set; }

        [DataMember]
        public Decimal CostPerMile { get; set; }

        [DataMember]
        public Decimal MilesPerGallon { get; set; }

        [DataMember]
        public int Odometer { get; set; }

        [DataMember]
        public string MessageIdPosition { get; set; }

        [DataMember]
        public string ServiceTypeIndicator { get; set; }

        [DataMember]
        public string MicrofilmReferenceNumber { get; set; }

        [DataMember]
        public string Flags { get; set; }

        [DataMember]
        public Decimal ExemptFederalTax { get; set; }

        [DataMember]
        public Decimal ExemptPrimaryMotorFuelTax { get; set; }

        [DataMember]
        public Decimal ExemptSecondaryMotorFuelTax { get; set; }

        [DataMember]
        public Decimal ExemptLocalSalesTax { get; set; }

        [DataMember]
        public Decimal ExemptStateSalesTax { get; set; }

        [DataMember]
        public Decimal ExemptMiscTax { get; set; }

        [DataMember]
        public string OrgNumber { get; set; }

        [DataMember]
        public string Filler { get; set; }

        [DataMember]
        public string DriverLevel2Name { get; set; }

        [DataMember]
        public string DriverLevel3Name { get; set; }

        [DataMember]
        public string VehicleLevel2Name { get; set; }

        [DataMember]
        public string VehicleLevel3Name { get; set; }

        [DataMember]
        public string CardLevel2Name { get; set; }

        [DataMember]
        public string CardLevel3Name { get; set; }

        [DataMember]
        public int DriverLevel4Id { get; set; }

        [DataMember]
        public string DriverLevel4Name { get; set; }

        [DataMember]
        public int DriverLevel5Id { get; set; }

        [DataMember]
        public string DriverLevel5Name { get; set; }

        [DataMember]
        public int DriverLevel6Id { get; set; }

        [DataMember]
        public string DriverLevel6Name { get; set; }

        [DataMember]
        public int DriverLevel7Id { get; set; }

        [DataMember]
        public string DriverLevel7Name { get; set; }

        [DataMember]
        public int VehicleLevel4Id { get; set; }

        [DataMember]
        public string VehicleLevel4Name { get; set; }

        [DataMember]
        public int VehicleLevel5Id { get; set; }

        [DataMember]
        public string VehicleLevel5Name { get; set; }

        [DataMember]
        public int VehicleLevel6Id { get; set; }

        [DataMember]
        public string VehicleLevel6Name { get; set; }

        [DataMember]
        public int VehicleLevel7Id { get; set; }

        [DataMember]
        public string VehicleLevel7Name { get; set; }

        [DataMember]
        public int CardLevel4Id { get; set; }

        [DataMember]
        public string CardLevel4Name { get; set; }

        [DataMember]
        public int CardLevel5Id { get; set; }


        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string SenderName { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public DateTime? FileDate { get; set; }

        [DataMember]
        public string FileType { get; set; }

        public bool FooterStamped { get; set; }

        [DataMember]
        public Decimal ExemptTaxes { get; set; }

        [DataMember]
        public int InvoiceCount { get; set; }
        
        [DataMember]
        public Decimal TotalProductUnits { get; set; }
        
        [DataMember]
        public Decimal TotalProductAmount { get; set; }
        
        [DataMember]
        public DateTime? StatementDate { get; set; }
    }
}
