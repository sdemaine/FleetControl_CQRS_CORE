using FleetControl.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Interfaces
{
    public interface IFleetControlDbContext
    {
        DbSet<Audit> Audit { get; set; }
        DbSet<AuditDataType> AuditDataType { get; set; }
        DbSet<AuditDetail> AuditDetail { get; set; }
        DbSet<AuditEvent> AuditEvent { get; set; }
        DbSet<AuditHistory> AuditHistory { get; set; }
        DbSet<AuditHistoryDetail> AuditHistoryDetail { get; set; }
        DbSet<BusinessAssociate> BusinessAssociate { get; set; }
        DbSet<BusinessHours> BusinessHours { get; set; }
        DbSet<Card> Card { get; set; }
        DbSet<CardAddress> CardAddress { get; set; }
        DbSet<CardCategory> CardCategory { get; set; }
        DbSet<CardClass> CardClass { get; set; }
        DbSet<CardImport> CardImport { get; set; }
        DbSet<CardNumberRegistry> CardNumberRegistry { get; set; }
        DbSet<CardPinRegistry> CardPinRegistry { get; set; }
        DbSet<ContractTaxLocation> ContractTaxLocation { get; set; }
        DbSet<CustomerClass> CustClass { get; set; }
        DbSet<Customer> Customer { get; set; }
        DbSet<CustomerAssignment> CustomerAssignment { get; set; }
        DbSet<CustomerCardCategory> CustomerCardCategory { get; set; }
        DbSet<CustomerGroup> CustomerGroup { get; set; }
        DbSet<CustomerGroupDetail> CustomerGroupDetail { get; set; }
        DbSet<CustomerMerchantLocation> CustomerMerchantLocation { get; set; }
        DbSet<CustomerPricingLocationGroup> CustomerPricingLocationGroup { get; set; }
        DbSet<CustomerPricingLocationWorkEntry> CustomerPricingLocationWorkEntry { get; set; }
        DbSet<CustomerStateLocation> CustomerStateLocation { get; set; }
        DbSet<CustomerZipCodeLocation> CustomerZipCodeLocation { get; set; }
        DbSet<DAMCard> Damcard { get; set; }
        DbSet<DAMCardConfirmation> DamcardConfirmation { get; set; }
        DbSet<DAMCustomer> Damcustomer { get; set; }
        DbSet<DAMDriver> Damdriver { get; set; }
        DbSet<DAMUploadDetail> DamuploadDetail { get; set; }
        DbSet<DAMVehicle> Damvehicle { get; set; }
        DbSet<Driver> Driver { get; set; }
        DbSet<DriverAssignment> DriverAssignment { get; set; }
        DbSet<DriverImport> DriverImport { get; set; }
        DbSet<DriverPinRegistry> DriverPinRegistry { get; set; }
        DbSet<DuplicateTransaction> DuplicateTransactions { get; set; }
        DbSet<ExternalDatabase> ExternalDatabase { get; set; }
        DbSet<ExternalDatabaseDetail> ExternalDatabaseDetail { get; set; }
        DbSet<FleetRec> FleetRec { get; set; }
        DbSet<FuelManagementGroup> FuelManagementGroup { get; set; }
        DbSet<FuelMasterTransactionLog> FuelMasterTransactionLog { get; set; }
        DbSet<ImportedTransaction> ImportedTransactions { get; set; }
        DbSet<InterfaceDatasource> InterfaceDatasource { get; set; }
        DbSet<List> List { get; set; }
        DbSet<Location> Location { get; set; }
        DbSet<LocationPricingLocationGroup> LocationPricingLocationGroup { get; set; }
        DbSet<MasterGroup> MasterGroups { get; set; }
        DbSet<NBCSProduct> Nbcsproducts { get; set; }
        DbSet<NumberRegistry> NumberRegistry { get; set; }
        DbSet<NYCHALabels> Nychalabels { get; set; }
        DbSet<OrgLevelDefinition> OrgLevelDefinition { get; set; }
        DbSet<OrgLevelName> OrgLevelName { get; set; }
        DbSet<ParticipantCode> ParticipantCode { get; set; }
        DbSet<PricingLocationGroup> PricingLocationGroup { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<PumpPrice> PumpPrices { get; set; }
        DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        DbSet<RetailAdder> RetailAdder { get; set; }
        DbSet<SampleTable> SampleTable { get; set; }
        DbSet<SendTransactionsErrorLog> SendTransactionsErrorLog { get; set; }
        DbSet<SiteCustomer> SiteCustomers { get; set; }
        DbSet<SiteProduct> SiteProduct { get; set; }
        DbSet<Site> Sites { get; set; }
        DbSet<SmallGallonTransaction> SmallGallonTransactions { get; set; }
        DbSet<SolarcLocale> SolarcLocale { get; set; }
        DbSet<SolarcProduct> SolArcProduct { get; set; }
        DbSet<Source> Source { get; set; }
        DbSet<SpecialCustomer> SpecialCustomer { get; set; }
        DbSet<SPR_CreateFleetRecExceptions> SprCreateFleetRecExceptions { get; set; }
        DbSet<State> State { get; set; }
        DbSet<SyncCard> SyncCard { get; set; }
        DbSet<SyncVehicle> SyncVehicle { get; set; }
        DbSet<TaxArea> TaxAreas { get; set; }
        DbSet<TaxLocation> TaxLocation { get; set; }
        DbSet<TempTransaction> TempTransaction { get; set; }
        DbSet<TransactionError> TransactionError { get; set; }
        DbSet<TransactionErrorDetail> TransactionErrorDetail { get; set; }
        DbSet<TransactionException> TransactionException { get; set; }
        DbSet<TransactionExceptionDetail> TransactionExceptionDetail { get; set; }
        DbSet<TransactionFlag> TransactionFlag { get; set; }
        DbSet<TransactionImportLog> TransactionImportLog { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<Vehicle> Vehicle { get; set; }
        DbSet<VehicleImport> VehicleImport { get; set; }
        DbSet<VehicleType> VehicleType { get; set; }
        DbSet<VoidTransaction> VoidTransactions { get; set; }
        DbSet<VoyagerErrorCodes> VoyagerErrorCodes { get; set; }
        DbSet<VoyagerSyncCard> VoyagerSyncCard { get; set; }
        DbSet<VoyagerSyncDriver> VoyagerSyncDriver { get; set; }
        DbSet<VoyagerSyncVehicle> VoyagerSyncVehicle { get; set; }
        DbSet<WinC6TransactionLog> WinC6transactionLog { get; set; }
        DbSet<YTD_Product_Totals> YtdProductTotals { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}