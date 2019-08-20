using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("FleetRec")]
    public class FleetRec : EntityBase
    {
        [DataMember]
        [Column("BillingWeek")]
        [MaxLength(10)]
        public string BillingWeek { get; set; }

        [DataMember]
        [Column("IssueLicensee")]
        [MaxLength(10)]
        public string IssueLicensee { get; set; }

        [DataMember]
        [Column("IssueLicenseeName")]
        [MaxLength(50)]
        public string IssueLicenseeName { get; set; }

        [DataMember]
        [Column("ReceiveLicensee")]
        [MaxLength(10)]
        public string ReceiveLicensee { get; set; }

        [DataMember]
        [Column("ReceiveLicenseeName")]
        [MaxLength(50)]
        public string ReceiveLicenseeName { get; set; }

        [DataMember]
        [Column("Division")]
        [MaxLength(10)]
        public string Division { get; set; }

        [DataMember]
        [Column("DivisionName")]
        [MaxLength(50)]
        public string DivisionName { get; set; }

        [DataMember]
        [Column("Merchant")]
        [MaxLength(10)]
        public string Merchant { get; set; }

        [DataMember]
        [Column("MerchantName")]
        [MaxLength(50)]
        public string MerchantName { get; set; }

        [DataMember]
        [Column("DeviceNo")]
        [MaxLength(10)]
        public string DeviceNo { get; set; }

        [DataMember]
        [Column("DeviceName")]
        [MaxLength(50)]
        public string DeviceName { get; set; }

        [DataMember]
        [Column("Customer")]
        [MaxLength(10)]
        public string Customer { get; set; }

        [DataMember]
        [Column("CustomerName")]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [DataMember]
        [Column("TranDate")]
        public DateTime TransactionDate { get; set; }

        [DataMember]
        [Column("TranNo")]
        [MaxLength(50)]
        public string TransactionNumber { get; set; }

        [DataMember]
        [Column("AuthorizationNumber")]
        [MaxLength(50)]
        public string AuthorizationNumber { get; set; }

        [DataMember]
        [Column("Product")]
        [MaxLength(50)]
        public string ProductCode { get; set; }

        [DataMember]
        [Column("ProductDescription")]
        [MaxLength(50)]
        public string ProductDescription { get; set; }

        [DataMember]
        [Column("ProductType")]
        [MaxLength(50)]
        public string ProductType { get; set; }

        [DataMember]
        [Column("QTY")]
        public decimal Quantity { get; set; }

        [DataMember]
        [Column("CustomerPrice")]
        public decimal CustomerPrice { get; set; }

        [DataMember]
        [Column("MerchantPrice")]
        public double MerchantPrice { get; set; }

        [DataMember]
        [Column("NetworkPrice")]
        public decimal NetworkPrice { get; set; }

        [DataMember]
        [Column("RetailPrice")]
        public decimal RetailPrice { get; set; }

        [DataMember]
        [Column("Basis")]
        public double Basis { get; set; }   //.. Reimbursement code (always 5.0)

        [DataMember]
        [Column("CardNumber")]
        [MaxLength(20)]
        public string CardNumber { get; set; }

        [DataMember]
        [Column("UserId")]
        public int UserId { get; set; }
    }
}
