using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace FleetControl.Domain
{
    [DataContract]
    [Table("Customer")]
    public class Customer : EntityBase
    {
        [DataMember]
        public int BAID { get; set; }

        [DataMember]
        [Display(Name = "Lifting Number")]
        [MaxLength(25)]
        public string LiftingNumber { get; set; }

        [DataMember]
        [Display(Name = "Voyager Account Id")]
        public int? VoyagerAccountId { get; set; }   //.. this is going to be the primary key within the Voyager application

        [DataMember]
        [Column("CustName")]
        [Display(Name = "Customer Name")]
        [MaxLength(50, ErrorMessage = "Customer name cannot exceed 50 characters in length.")]
        public string CustomerName { get; set; }

        [DataMember]
        [Display(Name = "Embossed Customer Name")]
        [MaxLength(25, ErrorMessage = "Customer name embossing cannot exceed 25 characters in length.")]
        public string EmbossedCustomerName { get; set; }

        [DataMember]
        [Required]
        [MaxLength(35, ErrorMessage = "Address cannot exceed 35 characters in length.")]
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [DataMember]
        [MaxLength(35, ErrorMessage = "Address2 cannot exceed 35 characters in length.")]
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [DataMember]
        [MaxLength(15, ErrorMessage = "City cannot exceed 15 characters in length.")]
        public string City { get; set; }

        [DataMember]
        [Column("State")]
        [MaxLength(2)]
        public string UsState { get; set; }

        [DataMember]
        [Required]
        [MaxLength(9, ErrorMessage = "Zip code is not in a valid format.")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Telephone number is required.")]
        [MaxLength(10)]
        public string Telephone { get; set; }

        [DataMember]
        [MaxLength(25, ErrorMessage = "Contact cannot exceed 25 characters.")]
        public string Contact { get; set; }

        [DataMember]
        [Column("CredLimit")]
        [Display(Name = "Credit Limit")]
        public int? CreditLimit { get; set; }

        [DataMember]
        [MaxLength(1)]
        public string LockCode { get; set; }

        [DataMember]
        public DateTime? LockDate { get; set; }

        [DataMember]
        [Display(Name = "Sales Person")]
        [MaxLength(25, ErrorMessage = "Salesperson cannot exceed 25 characters.")]
        public string SalesPerson { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Billing Code")]
        public string BillingCode { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Wet Hosing")]
        public string WetHosing { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "NYC Account")]
        public string NYCAccount { get; set; }

        [DataMember]
        public DateTime? LastActivityDate { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Special Customer Code")]
        public string SpecialCustomerCode { get; set; }

        [DataMember]
        [MaxLength(3, ErrorMessage = "FMR Group length cannot exceed 3 characters.")]
        [Display(Name = "FMR Group")]
        public string FMRGroup { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Invoice Separation")]
        public string InvoiceSeparation { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Pin Generation")]
        public string PinGeneration { get; set; }

        [DataMember]
        [Display(Name = "Product Use")]
        public ProductUse ProductUse { get; set; }

        [DataMember]
        [Display(Name = "Transaction Dollar Limit")]
        public int? TransactionDollarLimit { get; set; }

        [DataMember]
        [Display(Name = "Transaction Dollar Limit Mode")]
        public HardSoftModes TransactionDollarLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Daily Dollar Limit")]
        public int? DailyDollarLimit { get; set; }

        [DataMember]
        [Display(Name = "Daily Dollar Limit Mode")]
        public HardSoftModes DailyDollarLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Weekly Dollar Limit")]
        public int? WeeklyDollarLimit { get; set; }

        [DataMember]
        [Display(Name = "Weekly Dollar Limit Mode")]
        public HardSoftModes WeeklyDollarLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Monthly Dollar Limit")]
        public int? MonthlyDollarLimit { get; set; }

        [DataMember]
        [Display(Name = "Monthly Dollar Limit Mode")]
        public HardSoftModes MonthlyDollarLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Daily Transaction Limit")]
        public int? DailyTransactionLimit { get; set; }

        [DataMember]
        [Display(Name = "Daily Transaction Limit Mode")]
        public HardSoftModes DailyTransactionLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Weekly Transaction Limit")]
        public int? WeeklyTransactionLimit { get; set; }

        [DataMember]
        [Display(Name = "Weekly Transaction Limit Mode")]
        public HardSoftModes WeeklyTransactionLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Monthly Transaction Limit")]
        public int? MonthlyTransactionLimit { get; set; }

        [DataMember]
        [Display(Name = "Monthly Transaction Limit Mode")]
        public HardSoftModes MonthlyTransactionLimitMode { get; set; }

        [DataMember]
        [Display(Name = "Purchase Day")]
        public PurchaseDayEnum PurchaseDay { get; set; }

        [DataMember]
        [Display(Name = "Purchase Day Mode")]
        public HardSoftExceptionModes PurchaseDayMode { get; set; }

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
        public HardSoftExceptionModes PurchaseDayBand1Mode { get; set; }

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
        public HardSoftExceptionModes PurchaseDayBand2Mode { get; set; }

        [DataMember]
        [Display(Name = "Odometer Validation")]
        public BooleanEnum OdometerValidation { get; set; }

        [DataMember]
        [Display(Name = "Odometer Type")]
        public OdometerType OdometerType { get; set; }

        [DataMember]
        [Display(Name = "Org Levels Used")]
        public int OrgLevelsUsed { get; set; }

        [DataMember]
        [Display(Name = "Department Required")]
        public BooleanEnum DepartmentRequired { get; set; }

        [DataMember]
        [Display(Name = "Company Selects Pin")]
        public BooleanEnum CompanySelectsPin { get; set; }   //.. Sprague establishes PIN ( 0 = No, 1 = Yes (default) )

        [DataMember]
        [Display(Name = "Company Selects Card Number")]
        public BooleanEnum CompanySelectsCardNumber { get; set; }

        [DataMember]
        [Display(Name = "Company Selects Vehicle Number")]
        public BooleanEnum CompanySelectsVehicleNumber { get; set; } //.. Sprague establishes VehicleId ( 0 = No, 1 = Yes (default) )

        [DataMember]
        [Display(Name = "Company Selects Driver Number")]
        public BooleanEnum CompanySelectsDriverNumber { get; set; }  //.. Sprague establishes DriverId ( 0 = No, 1 = Yes (default) )

        [Display(Name = "Cards Tied To Entity")]
        [DataMember]
        public CardEntityType CardsTiedToEntity { get; set; }   //.. Cards tied to vehicle or driver --- 0 = Vehicle (default), 1 = Driver, 3 = None

        [DataMember]
        [Display(Name = "Card Prompt Pattern")]
        public CardPromptPattern CardPromptPattern { get; set; }  //.. Card Prompts for data at pump --- 0 = PIN # (default), 1 = Driver Id, 2 = Vehicle Id

        [DataMember]                                    //.. 0 = No Embossing, 1 = Vehicle License, 2 = Description of Vehicle, 3 = VIN Number, 4 = Driver Name
        [Display(Name = "Embossing On Card")]
        public EmbossingOnCard EmbossingOnCard { get; set; }     //.. 5 = Vehicle License or Driver Name, 6 = Vehicle Description or Driver Name, 7 = VIN Number or Driver Name

        [DataMember]
        [Display(Name = "Embossing Element 1")]
        public EmbossingElement EmbossingElement1 { get; set; }

        [DataMember]
        [Display(Name = "Embossing Element 2")]
        public EmbossingElement EmbossingElement2 { get; set; }

        [DataMember]
        [Display(Name = "Embossing Element 3")]
        public EmbossingElement EmbossingElement3 { get; set; }

        [DataMember]
        [Display(Name = "Internal Customer")]
        public BooleanEnum InternalCustomer { get; set; }

        [DataMember]
        [Display(Name = "Status")]
        public StatusMode Status { get; set; }

        [DataMember]
        [Display(Name = "Retail Customer")]
        public BooleanEnum RetailCustomer { get; set; }

        [DataMember]
        [Display(Name = "PO Required")]
        public BooleanEnum PORequired { get; set; }

        [DataMember]
        [MaxLength(1)]
        [Display(Name = "Billing Frequency")]
        public string BillingFrequency { get; set; }

        [DataMember]
        public CardRestrictionCode RestrictionCode { get; set; }

        [DataMember]
        public string CustNo { get; set; }

        [DataMember]
        public string ExternalDatabaseFilePath { get; set; }

        [DataMember]
        public bool IsConsignment { get; set; }

        [DataMember]
        public int MinDriverNumber { get; set; }

        [DataMember]
        public int MaxDriverNumber { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string ExternalFMSNumber { get; set; }

        [DataMember]
        public bool IsFuelMaster { get; set; }

        [DataMember]
        public bool IsWinC6 { get; set; }

        [DataMember]
        public bool IsVoyager { get; set; }

        //[DataMember]
        //public int? BusinessHoursId { get; set; }

        //[DataMember]
        //public virtual BusinessHours BusinessHours { get; set; }

        [DataMember]
        public BooleanEnum DepartmentRequiredForDriver { get; set; }

        [DataMember]
        public BooleanEnum DepartmentRequiredForCard { get; set; }

        [DataMember]
        public BooleanEnum DepartmentRequiredForVehicle { get; set; }

        [DataMember]
        public int? CardAddressId { get; set; }
    }
}
