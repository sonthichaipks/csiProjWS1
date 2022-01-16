using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsPriceChange
    {
        public DateTime EffectiveDate { get; set; }
        public string PluCode { get; set; }
        public short SellUnitPrice1Fg { get; set; }
        public short SellUnitPrice2Fg { get; set; }
        public short SellUnitPrice3Fg { get; set; }
        public short SellUnitPrice4Fg { get; set; }
        public short SellUnitPrice5Fg { get; set; }
        public short SellUnitPrice6Fg { get; set; }
        public decimal SellUnitPrice1 { get; set; }
        public decimal SellUnitPrice2 { get; set; }
        public decimal SellUnitPrice3 { get; set; }
        public decimal SellUnitPrice4 { get; set; }
        public decimal SellUnitPrice5 { get; set; }
        public decimal SellUnitPrice6 { get; set; }
        public short AppovedFg { get; set; }
        public short PosFg { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
