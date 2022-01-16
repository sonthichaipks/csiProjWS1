using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsTaxInvoiceAddress
    {
        public string TaxInvName { get; set; }
        public string TaxInvAddressLine1 { get; set; }
        public string TaxInvAddressLine2 { get; set; }
        public string TaxInvAddressLine3 { get; set; }
        public string TaxId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
