using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsTaxInvoiceHd
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public string DocType { get; set; }
        public string RefDocNo { get; set; }
        public string TaxInvName { get; set; }
        public string TaxInvAddressLine1 { get; set; }
        public string TaxInvAddressLine2 { get; set; }
        public string TaxInvAddressLine3 { get; set; }
        public string TaxId { get; set; }
        public string SalesVatType { get; set; }
        public decimal GrossAmt { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal ChargeAmt { get; set; }
        public decimal NetAmt { get; set; }
        public decimal VatAmt { get; set; }
        public short NoOfPrint { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
