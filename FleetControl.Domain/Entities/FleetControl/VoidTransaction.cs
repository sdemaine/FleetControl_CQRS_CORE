using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("VoidTransactions")]
    public class VoidTransaction : EntityBase
    {
        [DataMember]
        [Column("DeviceNo")]
        [MaxLength(7)]
        public string DeviceNo { get; set; }

        [DataMember]
        [Column("TranDate")]
        public DateTime TranDate { get; set; }

        [DataMember]
        [Column("TranTime")]
        [MaxLength(4)]
        public string TranTime { get; set; }

        [DataMember]
        [Column("TranNo")]
        [MaxLength(4)]
        public string TranNo { get; set; }

        [DataMember]
        [Column("TranType4")]
        [MaxLength(4)]
        public string TranType4 { get; set; }

        [DataMember]
        [Column("Item")]
        [MaxLength(2)]
        public string Item { get; set; }

        [DataMember]
        [Column("SiteFran")]
        [MaxLength(5)]
        public string SiteLicenseeNumber { get; set; }

        [DataMember]
        [Column("CardNo")]
        [MaxLength(19)]
        public string CardNumber { get; set; }

        [DataMember]
        [Display(Name = "Customer Card #")]
        public string CustomerCardNumber { get; set; }

        [DataMember]
        [Column("FranNo")]
        [MaxLength(10)]
        public string PropertyName { get; set; }

        [DataMember]
        [Column("CustNo")]
        [MaxLength(5)]
        public string CustomerNumber { get; set; }

        [DataMember]
        [Column("VehcNo")]
        [MaxLength(5)]
        public string VehicleNumber { get; set; }

        [DataMember]
        [Column("EmplNo")]
        [MaxLength(5)]
        public string EmplNo { get; set; }

        [DataMember]
        [Column("Odometer")]
        [MaxLength(6)]
        public string Odometer { get; set; }

        [DataMember]
        [Column("Pump")]
        [MaxLength(2)]
        public string Pump { get; set; }

        [DataMember]
        [Column("Prod")]
        [MaxLength(2)]
        public string ProductCode { get; set; }

        [DataMember]
        [Column("AmtGal")]
        public double AmountOfGallons { get; set; }

        [DataMember]
        [Column("Price")]
        public decimal Price { get; set; }

        [DataMember]
        [Column("TaxFlag")]
        [MaxLength(1)]
        public string TaxFlag { get; set; }

        [DataMember]
        [Column("ErrorCond")]
        [MaxLength(2)]
        public string ErrorCondition { get; set; }

        [DataMember]
        [Column("StationReimbursementAmount")]
        public decimal StationReimbursementAmount { get; set; }

        [DataMember]
        [Column("CardNoShort")]
        [MaxLength(6)]
        public string CardNumberShort { get; set; }

        [DataMember]
        [Column("StationReimbursementActual")]
        public double StationReimbursementActual { get; set; }

        [DataMember]
        [Column("FleetNetWeek")]
        [MaxLength(6)]
        public string FleetNetWeek { get; set; }

        [DataMember]
        [Column("FleetNetTranNo")]
        [MaxLength(10)]
        public string FleetNetTranNo { get; set; }

        [DataMember]
        [Column("PumpPrice")]
        public double PumpPrice { get; set; }

        [DataMember]
        [Column("OrgnlSRAExtnlDcmntNmbr")]
        [MaxLength(80)]
        public string OriginalSRAExternalDocumentNumber { get; set; }

        [DataMember]
        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }

        [DataMember]
        [Column("UserId")]
        public int UserId { get; set; }

        [DataMember]
        [Column("DateProcessed")]
        public DateTime DateProcessed { get; set; }

        [DataMember]
        [Column("SRAExtnlDcmntNmbr")]
        [MaxLength(80)]
        public string SRAExternalDocumentNumber { get; set; }

        [DataMember]
        [Column("PostedCustomerSaleAmount")]
        public double PostedCustomerSaleAmount { get; set; }
    }
}
