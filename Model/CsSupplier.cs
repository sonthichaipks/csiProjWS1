using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsSupplier
    {
        public int Id { get; set; }
        public string SupplId { get; set; }
        public string SupplName { get; set; }
        public short SupplType { get; set; }
        public string ContactName { get; set; }
        public string SupplAddress { get; set; }
        public string SupplRegName { get; set; }
        public string SupplRegAddress { get; set; }
        public string SupplTaxId { get; set; }
        public short? ConsignFg { get; set; }
        public decimal ConsignGp { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
