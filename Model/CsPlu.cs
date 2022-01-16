using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsPlu
    {
        public int Id { get; set; }
        public string ArticleCode { get; set; }
        public string SkuCode { get; set; }
        public string PluCode { get; set; }
        public string PluIntCode { get; set; }
        public string PluDesc { get; set; }
        public string PluShortDesc { get; set; }
        public string StyleId { get; set; }
        public string ColorId { get; set; }
        public string SizeId { get; set; }
        public string TasteId { get; set; }
        public string MatTypeId { get; set; }
        public string SellUnit { get; set; }
        public decimal SellUnitRatio { get; set; }
        public decimal SellUnitPrice1 { get; set; }
        public decimal SellUnitPrice2 { get; set; }
        public decimal SellUnitPrice3 { get; set; }
        public decimal SellUnitPrice4 { get; set; }
        public decimal SellUnitPrice5 { get; set; }
        public decimal SellUnitPrice6 { get; set; }
        public decimal DeliverCost { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
