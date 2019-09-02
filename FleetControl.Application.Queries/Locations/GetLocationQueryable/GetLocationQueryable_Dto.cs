using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Application.Queries.LocationPricingGroups;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Locations.GetLocationQueryable
{
    public class GetLocationQueryable_Dto : IHaveCustomMapping
    {
        public string DeviceNo { get; set; }

        public string Name { get; set; }

        public string Fuels { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        public string Zip { get; set; }

        public string Zip4 { get; set; }

        public string Phone { get; set; }

        public string Hour1 { get; set; }

        public string Hour2 { get; set; }

        public string Truck { get; set; }

        public string Contact { get; set; }

        public string Directions1 { get; set; }

        public string Directions2 { get; set; }

        public string Private { get; set; }

        public int ParticipantCode { get; set; }

        public string Closed { get; set; }

        public SiteType SiteType { get; set; }

        public SourceSystem SourceSystem { get; set; }

        public int? ExternalSiteId { get; set; }

        public string ViewOnTaxListing { get; set; }

        public string TaxArea { get; set; }

        public string NYCContractSite { get; set; }

        public string ExceptionReportAltPhone { get; set; }

        public string SiteName { get; set; }

        public string ConsignmentEffectiveDate { get; set; }

        public string BrandedStation { get; set; }

        public string EOMTaxExempt { get; set; }

        public string CostPlusPubCode { get; set; }

        public string MailName { get; set; }

        public string MailAddress { get; set; }

        public string MailCity { get; set; }

        public string MailState { get; set; }

        public string MailZip { get; set; }

        public string MailAttn { get; set; }

        public string BillingCycle { get; set; }

        public string Off_OnSiteType { get; set; } 

        public string IGASCAShipTo { get; set; }

        public string JDELocation { get; set; }

        public double Minus01 { get; set; }

        public double Minus02 { get; set; }

        public double Minus03 { get; set; }

        public double Minus31 { get; set; }

        public double RemitPercent { get; set; }

        public string IGASCA { get; set; }

        public int? TaxLocaleId { get; set; }

        public string Notes { get; set; }

        public string NeedsReview { get; set; }


        public bool HasRelatedTransactions { get; set; }

        public bool Active { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Location, GetLocationQueryable_Dto>()
                ;
        }
    }
}
