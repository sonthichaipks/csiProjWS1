using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class CsPara
    {
        public string BizName { get; set; }
        public string BizAddressLine1 { get; set; }
        public string BizAddressLine2 { get; set; }
        public string BizAddressLine3 { get; set; }
        public string TelId { get; set; }
        public string FaxId { get; set; }
        public string Email { get; set; }
        public string RegId { get; set; }
        public string TaxId { get; set; }
        public string BizType { get; set; }
        public short VatFg { get; set; }
        public string TaxInvName { get; set; }
        public string TaxInvAddrLine1 { get; set; }
        public string TaxInvAddrLine2 { get; set; }
        public string TaxInvAddrLine3 { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
