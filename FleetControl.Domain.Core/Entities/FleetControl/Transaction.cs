using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("Transactions")]
    public class Transaction : EntityBase
    {
        [DataMember]
        [MaxLength(15)]
        [Column("TranNo")]
        public string TransactionNumber { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public virtual Customer Customer { get; set; }

        [DataMember]
        public int? AccountNumber { get; set; }  // Limited by Voyager to 9-digits

        [DataMember]
        public int? AccountLevel1Id { get; set; }   // SPRAGUE OPERATING RESOURCES

        [DataMember]
        [MaxLength(5)]
        public string CustNo { get; set; }

        [DataMember]
        public int LocationId { get; set; } // identifies retail service station. Used as LcleNme in SolArc
        // (Concatenated with Participant Code abbrev. to make up Solarc LcleNme)

        [DataMember]
        public virtual Location Location { get; set; }

        [DataMember]
        public int ParticipantCode { get; set; }

        [DataMember]
        public string MerchantAccountId { get; set; }

        [DataMember]
        [Column("TranDate")]
        [DataType(DataType.Date)]
        public DateTime TransactionDate { get; set; }

        [DataMember]
        [Column("TranTime")]
        [MaxLength(4)]
        public string TransactionTime { get; set; }

        [DataMember]
        [Column("TranType4")]
        [MaxLength(4)]
        public string TransactionType { get; set; }

        [DataMember]
        public DateTime? PostDate { get; set; }

        // FullPrice, PumpPrice, TotalProductAmount, TotalProductUnits

        [DataMember]
        public int? CardId { get; set; }

        [DataMember]
        public virtual Card Card { get; set; }

        [DataMember]
        public string ExternalCardId { get; set; }

        [DataMember]
        [Display(Name = "Vehicle")]
        public int? VehicleId { get; set; }

        [DataMember]
        public virtual Vehicle Vehicle { get; set; }

        [DataMember]
        public string ExternalVehicleId { get; set; }

        [DataMember]
        public int? DriverId { get; set; }

        [DataMember]
        public virtual Driver Driver { get; set; }

        [DataMember]
        public string ExternalDriverId { get; set; }

        [DataMember]
        public int? Odometer { get; set; }

        [DataMember]
        [MaxLength(2)]
        public string Pump { get; set; }

        [DataMember]
        [Column("Prod")]
        [MaxLength(4)]
        public string ProductCode { get; set; }

        [DataMember]
        [Column("ProdId")]
        public int ProductId { get; set; }

        [DataMember]
        public virtual Product Product { get; set; }

        [DataMember]
        [Column("Price")]
        public double? CostPerUnit { get; set; }

        [DataMember]
        [Column("AmtGal")]
        public double TotalProductUnits { get; set; }

        [DataMember]
        public double PumpPrice { get; set; }

        [DataMember]
        public double? CostPerMile { get; set; }

        [DataMember]
        public double? MilesPerGallon { get; set; }

        [DataMember]
        [Column("FedEx")]
        public double? FederalExciseTaxRate { get; set; }   //.. Federal Excise Tax rate per gallon at location (calculated by Sprague, round to three decimal precision).
        //.. Some Customers exempt from Fed Excise Tax EXCEPT Fed LUST Tax value should be 0.001 if exempted; 0.184 when not exempt.
        //.. Same value as FederalExciseRate.  3 decimal precision.
        [DataMember]
        [Column("StaEx")]
        public double? StateExciseTaxPerGallonRate { get; set; }

        [DataMember]
        [Column("StaSales")]
        public double? StateSalesTaxPerGallonRate { get; set; }

        [DataMember]
        public double? OtherTax { get; set; }

        [DataMember]
        [MaxLength(1)]
        public string TaxFlag { get; set; }     //.. 8 = Federal Excise Tax Only, A = Federal Excise & State Sales Tax, F = All Taxes (Fed Ex, State Ex, State Sales)

        [DataMember]                                //.. 1 = E-Swiped, 2 = E-Keyed, 4 = E-Swiped-Offline (Floor limit Approval Used)
        public string CaptureMethod { get; set; }      //.. 5 = E-Keyed Offline (Floor limit approval used), 8 = Card Activated Reader(CRIND, Island Card reader)  9 Paper

        [DataMember]
        public string ServiceTypeIndicator { get; set; } //.. 0 = Self Service, 1 = Full Service, 2 = Other, 9 = Unknown

        [DataMember]
        [MaxLength(15)]
        public string MicrofileRefNumber { get; set; }  //.. Voyager Microfilm reference number for archived ticket

        [DataMember]
        [MaxLength(3)]
        public string ExceptionFlags { get; set; }  //.. A = Pattern Discrepancy (Time/Day) on Driver, C = Customer Activated Terminal, Island Card reader
        //.. D = Pattern Discrepancy (Time/Day) on  Vehicle, E = Estimated Odometer, F = Full Service, G = MPG Variance
        //.. M = Manual Transaction, P = Product Variance, X = Excess Vehicle Capacity
        [DataMember]
        public double? CustomerSalesAmount { get; set; }

        [DataMember]
        public double? UnpaidTaxes { get; set; }

        [DataMember]
        public double? StationReimbursementAmount { get; set; }

        [DataMember]
        [MaxLength(2)]
        public string TaxArea { get; set; }         //.. A two digit code that refers to a state or a NY County or a NY city that has it’s own tax rate.
        //.. Populated by selected Tax area on location (NAtionalDirectory).

        [DataMember]
        public double? StationReimbursementActual { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string MerchantInvoiceNumber { get; set; } //.. Voyager Invoice provided when transaction was billed to Sprague

        [DataMember]
        [MaxLength(2)]
        public string Source { get; set; }

        [DataMember]
        [Column("SRAExtrnlDcmntNmbr")]
        [MaxLength(80)]
        public string SRAExternalDocumentNumber { get; set; }

        [DataMember]
        public decimal? FederalExciseTaxAmount { get; set; }

        [DataMember]
        public decimal? StateExciseTaxAmount { get; set; }

        [DataMember]
        public decimal? PBTAmount { get; set; }

        [DataMember]
        public decimal? SalesTaxPerGallonAmount { get; set; }

        [DataMember]
        public decimal? SalesTaxPercentAmount { get; set; }

        [DataMember]
        public double? PBTRate { get; set; }

        [DataMember]
        public double? SalesTaxPerGallonRate { get; set; }

        [DataMember]
        public double? SalesTaxPercentRate { get; set; }

        [DataMember]
        public double? ProductBasePrice { get; set; }

        [DataMember]
        public double? SolarcProductPrice { get; set; }

        [DataMember]
        public double? FullPrice { get; set; }

        [DataMember]
        public int TaxLocaleId { get; set; }

        [DataMember]
        public DateTime VoyagerPostDate { get; set; }

        [DataMember]
        [Column("PerUnitCOGS")]
        public double? PerUnitCostOfGoodsSold { get; set; }

        [DataMember]
        public int? HourMeter { get; set; }

        [DataMember]
        public int DriverLevel2Id { get; set; }

        [DataMember]
        public int? DriverLevel3Id { get; set; }

        [DataMember]
        public int? DriverLevel4Id { get; set; }

        [DataMember]
        public int? DriverLevel5Id { get; set; }

        [DataMember]
        public int? DriverLevel6Id { get; set; }

        [DataMember]
        public int? DriverLevel7Id { get; set; }

        [DataMember]
        public int VehicleLevel2Id { get; set; }

        [DataMember]
        public int? VehicleLevel3Id { get; set; }

        [DataMember]
        public int? VehicleLevel4Id { get; set; }

        [DataMember]
        public int? VehicleLevel5Id { get; set; }

        [DataMember]
        public int? VehicleLevel6Id { get; set; }

        [DataMember]
        public int? VehicleLevel7Id { get; set; }

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
        public string DriverUserCode1 { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string DriverUserCode2 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string DriverUserCode3 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string DriverUserCode4 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string DriverUserCode5 { get; set; }

        [DataMember]
        [MaxLength(13)]
        public string VehicleUserCode1 { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string VehicleUserCode2 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string VehicleUserCode3 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string VehicleUserCode4 { get; set; }

        [DataMember]
        [MaxLength(8)]
        public string VehicleUserCode5 { get; set; }

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
        public int? PricingLocationGroupId { get; set; }

        [DataMember]
        public int? CustomerPricingLocationGroupId { get; set; }

        [DataMember]
        public int? PriceServiceId { get; set; }

        [DataMember]
        public int BillToOrgLevelDefinitionId { get; set; }

        [DataMember]
        public int ShipToOrgLevelDefinitionId { get; set; }

        [DataMember]
        public BooleanEnum IsRetail { get; set; }

        [DataMember]
        public int VoyagerCardLevel2Id { get; set; }

        [DataMember]
        public int VoyagerCardLevel3Id { get; set; }

        [DataMember]
        public int VoyagerCardLevel4Id { get; set; }

        [DataMember]
        public int VoyagerCardLevel5Id { get; set; }

        [DataMember]
        public int VoyagerCardLevel6Id { get; set; }

        [DataMember]
        public int VoyagerCardLevel7Id { get; set; }

        [DataMember]
        public int VoyagerVehicleLevel2Id { get; set; }

        [DataMember]
        public int VoyagerVehicleLevel3Id { get; set; }

        [DataMember]
        public int VoyagerVehicleLevel4Id { get; set; }

        [DataMember]
        public int VoyagerVehicleLevel5Id { get; set; }

        [DataMember]
        public int VoyagerVehicleLevel6Id { get; set; }

        [DataMember]
        public int VoyagerVehicleLevel7Id { get; set; }

        [DataMember]
        public int VoyagerDriverLevel2Id { get; set; }

        [DataMember]
        public int VoyagerDriverLevel3Id { get; set; }

        [DataMember]
        public int VoyagerDriverLevel4Id { get; set; }

        [DataMember]
        public int VoyagerDriverLevel5Id { get; set; }

        [DataMember]
        public int VoyagerDriverLevel6Id { get; set; }

        [DataMember]
        public int VoyagerDriverLevel7Id { get; set; }

        [DataMember]
        public string Filename { get; set; }

        [DataMember]
        public int SiteNumber { get; set; }

        [DataMember]
        public int Sequence { get; set; }

        [DataMember]
        [MaxLength(30)]
        public string PurchaseOrderNumber { get; set; }

        [DataMember]
        public bool ExceptionsProcessed { get; set; }
    }
}
