using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Transactions
{
    public class GetTransactionsQueryable_Dto : IHaveCustomMapping
    {
        public string TransactionNumber { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int? AccountNumber { get; set; }  // Limited by Voyager to 9-digits

        public int? AccountLevel1Id { get; set; }   // SPRAGUE OPERATING RESOURCES

        public string CustNo { get; set; }

        public int LocationId { get; set; } // identifies retail service station. Used as LcleNme in SolArc

        public virtual Location Location { get; set; }

        public int ParticipantCode { get; set; }

        public string MerchantAccountId { get; set; }

        public DateTime TransactionDate { get; set; }
        public string TransactionTime { get; set; }

        public string TransactionType { get; set; }

        public DateTime? PostDate { get; set; }

        public int? CardId { get; set; }

        public virtual Card Card { get; set; }

        public string ExternalCardId { get; set; }

        public int? VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public string ExternalVehicleId { get; set; }

        public int? DriverId { get; set; }

        public virtual Customer Driver { get; set; }

        public string ExternalDriverId { get; set; }

        public int? Odometer { get; set; }

        public string Pump { get; set; }
        public string ProductCode { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public double? CostPerUnit { get; set; }

        public double TotalProductUnits { get; set; }

        public double PumpPrice { get; set; }

        public double? CostPerMile { get; set; }

        public double? MilesPerGallon { get; set; }

        public double? FederalExciseTaxRate { get; set; }   //.. Federal Excise Tax rate per gallon at location (calculated by Sprague, round to three decimal precision).
        public double? StateExciseTaxPerGallonRate { get; set; }

        public double? StateSalesTaxPerGallonRate { get; set; }

        public double? OtherTax { get; set; }

        public string TaxFlag { get; set; }     //.. 8 = Federal Excise Tax Only, A = Federal Excise & State Sales Tax, F = All Taxes (Fed Ex, State Ex, State Sales)

        public string CaptureMethod { get; set; }      //.. 5 = E-Keyed Offline (Floor limit approval used), 8 = Card Activated Reader(CRIND, Island Card reader)  9 Paper

        public string ServiceTypeIndicator { get; set; } //.. 0 = Self Service, 1 = Full Service, 2 = Other, 9 = Unknown

        public string MicrofileRefNumber { get; set; }  //.. Voyager Microfilm reference number for archived ticket

        public string ExceptionFlags { get; set; }  //.. A = Pattern Discrepancy (Time/Day) on Driver, C = Customer Activated Terminal, Island Card reader
        public double? CustomerSalesAmount { get; set; }

        public double? UnpaidTaxes { get; set; }

        public double? StationReimbursementAmount { get; set; }

        public string TaxArea { get; set; }         //.. A two digit code that refers to a state or a NY County or a NY city that has it’s own tax rate.

        public double? StationReimbursementActual { get; set; }

        public string MerchantInvoiceNumber { get; set; } //.. Voyager Invoice provided when transaction was billed to Sprague

        public string Source { get; set; }

        public string SRAExternalDocumentNumber { get; set; }

        public decimal? FederalExciseTaxAmount { get; set; }

        public decimal? StateExciseTaxAmount { get; set; }

        public decimal? PBTAmount { get; set; }
        public decimal? SalesTaxPerGallonAmount { get; set; }

        public decimal? SalesTaxPercentAmount { get; set; }

        public double? PBTRate { get; set; }

        public double? SalesTaxPerGallonRate { get; set; }

        public double? SalesTaxPercentRate { get; set; }

        public double? ProductBasePrice { get; set; }

        public double? SolarcProductPrice { get; set; }

        public double? FullPrice { get; set; }

        public int TaxLocaleId { get; set; }

        public DateTime VoyagerPostDate { get; set; }

        public double? PerUnitCostOfGoodsSold { get; set; }

        public int? HourMeter { get; set; }

        public int DriverLevel2Id { get; set; }

        public int? DriverLevel3Id { get; set; }

        public int? DriverLevel4Id { get; set; }

        public int? DriverLevel5Id { get; set; }

        public int? DriverLevel6Id { get; set; }

        public int? DriverLevel7Id { get; set; }

        public int VehicleLevel2Id { get; set; }

        public int? VehicleLevel3Id { get; set; }

        public int? VehicleLevel4Id { get; set; }

        public int? VehicleLevel5Id { get; set; }

        public int? VehicleLevel6Id { get; set; }

        public int? VehicleLevel7Id { get; set; }

        public int CardLevel2Id { get; set; }

        public int? CardLevel3Id { get; set; }

        public int? CardLevel4Id { get; set; }

        public int? CardLevel5Id { get; set; }

        public int? CardLevel6Id { get; set; }

        public int? CardLevel7Id { get; set; }

        public string DriverUserCode1 { get; set; }

        public string DriverUserCode2 { get; set; }

        public string DriverUserCode3 { get; set; }

        public string DriverUserCode4 { get; set; }

        public string DriverUserCode5 { get; set; }

        public string VehicleUserCode1 { get; set; }

        public string VehicleUserCode2 { get; set; }

        public string VehicleUserCode3 { get; set; }

        public string VehicleUserCode4 { get; set; }

        public string VehicleUserCode5 { get; set; }

        public string CardUserCode1 { get; set; }

        public string CardUserCode2 { get; set; }

        public string CardUserCode3 { get; set; }

        public string CardUserCode4 { get; set; }

        public string CardUserCode5 { get; set; }

        public int? PricingLocationGroupId { get; set; }

        public int? CustomerPricingLocationGroupId { get; set; }

        public int? PriceServiceId { get; set; }

        public int BillToOrgLevelDefinitionId { get; set; }

        public int ShipToOrgLevelDefinitionId { get; set; }

        public BooleanEnum IsRetail { get; set; }

        public int VoyagerCardLevel2Id { get; set; }

        public int VoyagerCardLevel3Id { get; set; }

        public int VoyagerCardLevel4Id { get; set; }

        public int VoyagerCardLevel5Id { get; set; }

        public int VoyagerCardLevel6Id { get; set; }

        public int VoyagerCardLevel7Id { get; set; }

        public int VoyagerVehicleLevel2Id { get; set; }

        public int VoyagerVehicleLevel3Id { get; set; }

        public int VoyagerVehicleLevel4Id { get; set; }

        public int VoyagerVehicleLevel5Id { get; set; }

        public int VoyagerVehicleLevel6Id { get; set; }

        public int VoyagerVehicleLevel7Id { get; set; }

        public int VoyagerDriverLevel2Id { get; set; }

        public int VoyagerDriverLevel3Id { get; set; }

        public int VoyagerDriverLevel4Id { get; set; }

        public int VoyagerDriverLevel5Id { get; set; }

        public int VoyagerDriverLevel6Id { get; set; }

        public int VoyagerDriverLevel7Id { get; set; }

        public string Filename { get; set; }

        public int SiteNumber { get; set; }

        public int Sequence { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public bool ExceptionsProcessed { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Transaction, GetTransactionsQueryable_Dto>()
                ;
        }
    }
}
