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
    public class UpdateFleetDriver_Dto : IHaveCustomMapping, IValidatableObject
    {
        #region Properties


        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleInitial { get; set; }


        public string LockCode { get; set; }


        public string TheirEmployeeNumber { get; set; }

        public int? DailyTransactionLimit { get; set; }

        public int DriverLevel2Id { get; set; }

        public int? DriverLevel3Id { get; set; }

        public int? DriverLevel4Id { get; set; }

        public int? DriverLevel5Id { get; set; }

        public int? DriverLevel6Id { get; set; }

        public int? DriverLevel7Id { get; set; }

        public string Class { get; set; }

        public int Sequence { get; set; }

        public int MENU { get; set; }

        public StatusMode Status { get; set; }

        public int UseCount { get; set; }

        public decimal Quantity { get; set; }

        public int? MinVehc { get; set; }

        public int? MaxVehc { get; set; }

        public string DriverUserCode1 { get; set; }

        public string DriverUserCode2 { get; set; }

        public string DriverUserCode3 { get; set; }

        public string DriverUserCode4 { get; set; }

        public string DriverUserCode5 { get; set; }




        public int? ClassId { get; set; }

        public bool IsConsignment { get; set; }


        public bool IsFuelMaster { get; set; }

        public bool IsWinC6 { get; set; }

        public bool IsVoyager { get; set; }


        #endregion

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Customer, UpdateFleetDriver_Dto>()
                .ReverseMap().ForMember(x => x.Id, opt => opt.Ignore())
                ;
        }

        public IEnumerable<ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            //if (!IsValidDate(Date))
            //{
            //    results.Add(new ValidationResult("Date must be within the last year."));
            //}

            return results;
        }
    }
}
