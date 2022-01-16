using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsTaxInvoiceDt
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public short LineItemNo { get; set; }
        public string PluCode { get; set; }
        public string ItemDescription { get; set; }
        public decimal Qty { get; set; }
        public string SerialNo { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExPrice { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal ItemCharge { get; set; }
        public decimal ItemNetExprice { get; set; }
        public string ItemVatType { get; set; }
        public short ItemPromoFg { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
