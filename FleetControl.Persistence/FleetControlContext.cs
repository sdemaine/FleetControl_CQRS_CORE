using System;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FleetControl.Persistence
{
    public partial class FleetControlDbContext : DbContext, IFleetControlDbContext
    {
        public FleetControlDbContext(DbContextOptions<FleetControlDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<AuditDataType> AuditDataType { get; set; }
        public virtual DbSet<AuditDetail> AuditDetail { get; set; }
        public virtual DbSet<AuditEvent> AuditEvent { get; set; }
        public virtual DbSet<AuditHistory> AuditHistory { get; set; }
        public virtual DbSet<AuditHistoryDetail> AuditHistoryDetail { get; set; }
        public virtual DbSet<BusinessAssociate> BusinessAssociate { get; set; }
        public virtual DbSet<BusinessHours> BusinessHours { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<CardAddress> CardAddress { get; set; }
        public virtual DbSet<CardCategory> CardCategory { get; set; }
        public virtual DbSet<CardClass> CardClass { get; set; }
        public virtual DbSet<CardImport> CardImport { get; set; }
        public virtual DbSet<CardNumberRegistry> CardNumberRegistry { get; set; }
        public virtual DbSet<CardPinRegistry> CardPinRegistry { get; set; }
        public virtual DbSet<ContractTaxLocation> ContractTaxLocation { get; set; }
        public virtual DbSet<CustomerClass> CustClass { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAssignment> CustomerAssignment { get; set; }
        public virtual DbSet<CustomerCardCategory> CustomerCardCategory { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroup { get; set; }
        public virtual DbSet<CustomerGroupDetail> CustomerGroupDetail { get; set; }
        public virtual DbSet<CustomerMerchantLocation> CustomerMerchantLocation { get; set; }
        public virtual DbSet<CustomerPricingLocationGroup> CustomerPricingLocationGroup { get; set; }
        public virtual DbSet<CustomerPricingLocationWorkEntry> CustomerPricingLocationWorkEntry { get; set; }
        public virtual DbSet<CustomerStateLocation> CustomerStateLocation { get; set; }
        public virtual DbSet<CustomerZipCodeLocation> CustomerZipCodeLocation { get; set; }
        public virtual DbSet<DAMCard> Damcard { get; set; }
        public virtual DbSet<DAMCardConfirmation> DamcardConfirmation { get; set; }
        public virtual DbSet<DAMCustomer> Damcustomer { get; set; }
        public virtual DbSet<DAMDriver> Damdriver { get; set; }
        public virtual DbSet<DAMUploadDetail> DamuploadDetail { get; set; }
        public virtual DbSet<DAMVehicle> Damvehicle { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<DriverAssignment> DriverAssignment { get; set; }
        public virtual DbSet<DriverImport> DriverImport { get; set; }
        public virtual DbSet<DriverPinRegistry> DriverPinRegistry { get; set; }
        public virtual DbSet<DuplicateTransaction> DuplicateTransactions { get; set; }
        public virtual DbSet<ExternalDatabase> ExternalDatabase { get; set; }
        public virtual DbSet<ExternalDatabaseDetail> ExternalDatabaseDetail { get; set; }
        public virtual DbSet<FleetRec> FleetRec { get; set; }
        public virtual DbSet<FuelManagementGroup> FuelManagementGroup { get; set; }
        public virtual DbSet<FuelMasterTransactionLog> FuelMasterTransactionLog { get; set; }
        public virtual DbSet<ImportedTransaction> ImportedTransactions { get; set; }
        public virtual DbSet<InterfaceDatasource> InterfaceDatasource { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationPricingLocationGroup> LocationPricingLocationGroup { get; set; }
        public virtual DbSet<MasterGroup> MasterGroups { get; set; }
        public virtual DbSet<NBCSProduct> Nbcsproducts { get; set; }
        public virtual DbSet<NumberRegistry> NumberRegistry { get; set; }
        public virtual DbSet<NYCHALabels> Nychalabels { get; set; }
        public virtual DbSet<OrgLevelDefinition> OrgLevelDefinition { get; set; }
        public virtual DbSet<OrgLevelName> OrgLevelName { get; set; }
        public virtual DbSet<ParticipantCode> ParticipantCode { get; set; }
        public virtual DbSet<PricingLocationGroup> PricingLocationGroup { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<PumpPrice> PumpPrices { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<RetailAdder> RetailAdder { get; set; }
        public virtual DbSet<SampleTable> SampleTable { get; set; }
        public virtual DbSet<SendTransactionsErrorLog> SendTransactionsErrorLog { get; set; }
        public virtual DbSet<SiteCustomer> SiteCustomers { get; set; }
        public virtual DbSet<SiteProduct> SiteProduct { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SmallGallonTransaction> SmallGallonTransactions { get; set; }
        public virtual DbSet<SolarcProduct> SolArcProduct { get; set; }
        public virtual DbSet<SolarcLocale> SolarcLocale { get; set; }
        public virtual DbSet<Source> Source { get; set; }
        public virtual DbSet<SpecialCustomer> SpecialCustomer { get; set; }
        public virtual DbSet<SPR_CreateFleetRecExceptions> SprCreateFleetRecExceptions { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<SyncCard> SyncCard { get; set; }
        public virtual DbSet<SyncVehicle> SyncVehicle { get; set; }
        public virtual DbSet<TaxArea> TaxAreas { get; set; }
        public virtual DbSet<TaxLocation> TaxLocation { get; set; }
        public virtual DbSet<TempTransaction> TempTransaction { get; set; }
        public virtual DbSet<TransactionError> TransactionError { get; set; }
        public virtual DbSet<TransactionErrorDetail> TransactionErrorDetail { get; set; }
        public virtual DbSet<TransactionException> TransactionException { get; set; }
        public virtual DbSet<TransactionExceptionDetail> TransactionExceptionDetail { get; set; }
        public virtual DbSet<TransactionFlag> TransactionFlag { get; set; }
        public virtual DbSet<TransactionImportLog> TransactionImportLog { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleImport> VehicleImport { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<VoidTransaction> VoidTransactions { get; set; }
        public virtual DbSet<VoyagerErrorCodes> VoyagerErrorCodes { get; set; }
        public virtual DbSet<VoyagerSyncCard> VoyagerSyncCard { get; set; }
        public virtual DbSet<VoyagerSyncDriver> VoyagerSyncDriver { get; set; }
        public virtual DbSet<VoyagerSyncVehicle> VoyagerSyncVehicle { get; set; }
        public virtual DbSet<WinC6TransactionLog> WinC6transactionLog { get; set; }
        public virtual DbSet<YTD_Product_Totals> YtdProductTotals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FleetControlDbContext).Assembly);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}