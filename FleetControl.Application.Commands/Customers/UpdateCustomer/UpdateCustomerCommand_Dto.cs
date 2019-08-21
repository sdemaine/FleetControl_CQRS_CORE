using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Commands.Customers.UpdateCustomer
{
    public class UpdateCustomerCommand_Dto : IHaveCustomMapping, IValidatableObject
    {
        #region Properties
        public int BAID { get; set; }

        public string LiftingNumber { get; set; }

        public int? VoyagerAccountId { get; set; }


        [Required, StringLength(25, ErrorMessage = "Customer name can only be 25 characters long")]

        public string CustomerName { get; set; }

        public string EmbossedCustomerName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string UsState { get; set; }

        public string ZipCode { get; set; }

        public string Telephone { get; set; }

        public string Contact { get; set; }

        public int? CreditLimit { get; set; }

        public string LockCode { get; set; }

        public DateTime? LockDate { get; set; }

        public string SalesPerson { get; set; }

        public string BillingCode { get; set; }

        public string WetHosing { get; set; }

        public string NYCAccount { get; set; }

        public string SpecialCustomerCode { get; set; }

        public string FMRGroup { get; set; }

        public string InvoiceSeparation { get; set; }

        public string PinGeneration { get; set; }

        public ProductUse ProductUse { get; set; }

        public int? TransactionDollarLimit { get; set; }

        public HardSoftModes TransactionDollarLimitMode { get; set; }

        public int? DailyDollarLimit { get; set; }

        public HardSoftModes DailyDollarLimitMode { get; set; }

        public int? WeeklyDollarLimit { get; set; }

        public HardSoftModes WeeklyDollarLimitMode { get; set; }

        public int? MonthlyDollarLimit { get; set; }

        public HardSoftModes MonthlyDollarLimitMode { get; set; }
        public int? DailyTransactionLimit { get; set; }

        public HardSoftModes DailyTransactionLimitMode { get; set; }

        public int? WeeklyTransactionLimit { get; set; }

        public HardSoftModes WeeklyTransactionLimitMode { get; set; }

        public int? MonthlyTransactionLimit { get; set; }

        public HardSoftModes MonthlyTransactionLimitMode { get; set; }

        public PurchaseDayEnum PurchaseDay { get; set; }

        public HardSoftExceptionModes PurchaseDayMode { get; set; }

        public HardSoftExceptionModes PurchaseDayBand1Mode { get; set; }

        public HardSoftExceptionModes PurchaseDayBand2Mode { get; set; }

        public BooleanEnum OdometerValidation { get; set; }

        public OdometerType OdometerType { get; set; }

        public int OrgLevelsUsed { get; set; }

        public BooleanEnum DepartmentRequired { get; set; }

        public BooleanEnum CompanySelectsPin { get; set; }   //.. Sprague establishes PIN ( 0 = No, 1 = Yes (default) )

        public BooleanEnum CompanySelectsCardNumber { get; set; }

        public BooleanEnum CompanySelectsVehicleNumber { get; set; } //.. Sprague establishes VehicleId ( 0 = No, 1 = Yes (default) )

        public BooleanEnum CompanySelectsDriverNumber { get; set; }  //.. Sprague establishes DriverId ( 0 = No, 1 = Yes (default) )

        public CardEntityType CardsTiedToEntity { get; set; }   //.. Cards tied to vehicle or driver --- 0 = Vehicle (default), 1 = Driver, 3 = None

        public CardPromptPattern CardPromptPattern { get; set; }  //.. Card Prompts for data at pump --- 0 = PIN # (default), 1 = Driver Id, 2 = Vehicle Id

        public EmbossingOnCard EmbossingOnCard { get; set; }     //.. 5 = Vehicle License or Driver Name, 6 = Vehicle Description or Driver Name, 7 = VIN Number or Driver Name

        public EmbossingElement EmbossingElement1 { get; set; }

        public EmbossingElement EmbossingElement2 { get; set; }

        public EmbossingElement EmbossingElement3 { get; set; }

        public BooleanEnum InternalCustomer { get; set; }

        public StatusMode Status { get; set; }

        public BooleanEnum RetailCustomer { get; set; }

        public BooleanEnum PORequired { get; set; }

        public string BillingFrequency { get; set; }

        public CardRestrictionCode RestrictionCode { get; set; }

        public string CustNo { get; set; }

        public string ExternalDatabaseFilePath { get; set; }

        public bool IsConsignment { get; set; }

        public int MinDriverNumber { get; set; }

        public int MaxDriverNumber { get; set; }

        public string ExternalFMSNumber { get; set; }

        public bool IsFuelMaster { get; set; }

        public bool IsWinC6 { get; set; }

        public bool IsVoyager { get; set; }

        public BooleanEnum DepartmentRequiredForDriver { get; set; }

        public BooleanEnum DepartmentRequiredForCard { get; set; }

        public BooleanEnum DepartmentRequiredForVehicle { get; set; }

        public int? CardAddressId { get; set; }

        #endregion

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Customer, UpdateCustomerCommand_Dto>()
                .ReverseMap()
                ;
        }

        public IEnumerable<ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            //if (!IsValidDate(Date))
            //{
            //    results.Add(new ValidationResult("Date must be within the last year."));
            //}

            if (!IsValidResourceGroup(BillingCode))
            {
                results.Add(new ValidationResult($"Invalid resource group"));
            }

            return results;
        }



        public enum Group
        {
            A,
            B,
            C
        }
        bool IsValidResourceGroup(string group)
        {
            foreach (var c in Enum.GetValues(typeof(Group)))
            {
                if (string.Equals(group.Trim(), $"{c}", StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
