using FleetControl.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("Location")]
    public class Location : EntityBase
    {
        [DataMember]
        [Column("DeviceNo")]
        [MaxLength(13)]
        public string DeviceNo { get; set; }

        [DataMember]
        [Column("Name")]
        [MaxLength(25)]
        public string Name { get; set; }

        [DataMember]
        [Column("Fuels")]
        [MaxLength(50)]
        public string Fuels { get; set; }

        [DataMember]
        [Column("Address")]
        [MaxLength(25)]
        public string Address { get; set; }

        [DataMember]
        [Column("City")]
        [MaxLength(17)]
        public string City { get; set; }

        [DataMember]
        [Column("State")]
        [MaxLength(2)]
        public string State { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string County { get; set; }

        [DataMember]
        [Column("Zip")]
        [MaxLength(5)]
        public string Zip { get; set; }

        [DataMember]
        [Column("Zip4")]
        [MaxLength(4)]
        public string Zip4 { get; set; }

        [DataMember]
        [Column("Phone")]
        [MaxLength(12)]
        public string Phone { get; set; }

        [DataMember]
        [Column("Hour1")]
        [MaxLength(9)]
        public string Hour1 { get; set; }

        [DataMember]
        [Column("Hour2")]
        [MaxLength(9)]
        public string Hour2 { get; set; }

        [DataMember]
        [Column("Truck")]
        [MaxLength(1)]
        public string Truck { get; set; }   //.. Trucks can access (0 = No, 1 = Yes)

        [DataMember]
        [Column("Contact")]
        [MaxLength(25)]
        public string Contact { get; set; }

        [DataMember]
        [Column("Direc1")]
        [MaxLength(40)]
        public string Directions1 { get; set; }

        [DataMember]
        [Column("Direc2")]
        [MaxLength(40)]
        public string Directions2 { get; set; }

        [DataMember]
        [Column("Private")]
        [MaxLength(1)]
        public string Private { get; set; }

        [DataMember]
        [Column("ParticipantCD")]
        public int ParticipantCode { get; set; }

        [DataMember]
        [Column("Closed")]
        [MaxLength(1)]
        public string Closed { get; set; }

        [DataMember]
        [Column("SiteType")]
        public SiteType SiteType { get; set; }

        [DataMember]
        [Column("SourceSystem")]
        public SourceSystem SourceSystem { get; set; }

        [DataMember]
        [Column("ExternalSiteId")]
        public int? ExternalSiteId { get; set; }

        [DataMember]
        [Column("ViewOnTaxListing")]
        [MaxLength(1)]
        public string ViewOnTaxListing { get; set; }

        [DataMember]
        [Column("TaxArea")]
        [MaxLength(2)]
        public string TaxArea { get; set; }

        [DataMember]
        [Column("NYCContractSite")]
        [MaxLength(1)]
        public string NYCContractSite { get; set; }

        [DataMember]
        [Column("ExceptionReportAltPhone")]
        [MaxLength(10)]
        public string ExceptionReportAltPhone { get; set; }

        //[DataMember]
        //[Column("PricingZone")]
        //[MaxLength(1)]
        //public string PricingZone { get; set; }

        //[DataMember]
        //[Column("ZonePricing")]
        //[MaxLength(1)]
        //public string ZonePricing { get; set; }

        [DataMember]
        [Column("SiteName")]
        [MaxLength(25)]
        public string SiteName { get; set; }

        [DataMember]
        [Column("ConsignmentEffectiveDate")]
        [MaxLength(8)]
        public string ConsignmentEffectiveDate { get; set; }

        [DataMember]
        [Column("BrandedStation")]
        [MaxLength(15)]
        public string BrandedStation { get; set; }

        [DataMember]
        [Column("EOMTaxExempt")]
        [MaxLength(1)]
        public string EOMTaxExempt { get; set; }

        [DataMember]
        [Column("CostPlusPubCode")]
        [MaxLength(3)]
        public string CostPlusPubCode { get; set; }

        [DataMember]
        [Column("MailName")]
        [MaxLength(40)]
        public string MailName { get; set; }

        [DataMember]
        [Column("MailAddress")]
        [MaxLength(40)]
        public string MailAddress { get; set; }

        [DataMember]
        [Column("MailCity")]
        [MaxLength(20)]
        public string MailCity { get; set; }

        [DataMember]
        [Column("MailState")]
        [MaxLength(2)]
        public string MailState { get; set; }

        [DataMember]
        [Column("MailZip")]
        [MaxLength(10)]
        public string MailZip { get; set; }

        [DataMember]
        [Column("MailAttn")]
        [MaxLength(20)]
        public string MailAttn { get; set; }

        [DataMember]
        [Column("BillingCycle")]
        [MaxLength(1)]
        public string BillingCycle { get; set; }

        [DataMember]
        [Column("Off_OnSiteType")]
        [MaxLength(1)]
        public string Off_OnSiteType { get; set; }  //.. C = Closed On Site (Customer Site, closed to public)
        //.. O = Open On Site (Customer Site, Open for other customers)
        //.. W = Wet Hosing, F = Off Site (General gas station)

        [DataMember]
        [Column("IGASCAShipTo")]
        [MaxLength(2)]
        public string IGASCAShipTo { get; set; }

        [DataMember]
        [Column("JDELocation")]
        [MaxLength(4)]
        public string JDELocation { get; set; }

        [DataMember]
        [Column("01Minus")]
        public double Minus01 { get; set; }

        [DataMember]
        [Column("02Minus")]
        public double Minus02 { get; set; }

        [DataMember]
        [Column("03Minus")]
        public double Minus03 { get; set; }

        [DataMember]
        [Column("31Minus")]
        public double Minus31 { get; set; }

        [DataMember]
        [Column("RemitPercent")]
        public double RemitPercent { get; set; }

        [DataMember]
        [Column("IGASCA")]
        [MaxLength(6)]
        public string IGASCA { get; set; }

        [DataMember]
        [Column("TaxLocaleId")]
        public int? TaxLocaleId { get; set; }

        [DataMember]
        public string Notes { get; set; }

        [DataMember]
        public string NeedsReview { get; set; }

        //[DataMember]
        //public bool CompleteRecord { get; set; }

        [DataMember]
        public bool HasRelatedTransactions { get; set; }

        [DataMember]
        public virtual ICollection<LocationPricingLocationGroup> LocationPricingLocationGroups { get; set; }

        [DataMember]
        public bool Active { get; set; }
    }
}
