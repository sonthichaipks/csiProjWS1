using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsSku
    {
        public int Id { get; set; }
        public string ArticleCode { get; set; }
        public string SkuCode { get; set; }
        public string StyleId { get; set; }
        public string ColorId { get; set; }
        public string SizeId { get; set; }
        public string TasteId { get; set; }
        public string MatTypeId { get; set; }
        public string SkuDesc { get; set; }
        public short StockFg { get; set; }
        public string StkUnit { get; set; }
        public string PurUnit { get; set; }
        public decimal PurUnitRatio { get; set; }
        public decimal PurUnitPrice { get; set; }
        public decimal MinStockQty { get; set; }
        public decimal MaxStockQty { get; set; }
        public decimal PurLeadTime { get; set; }
        public decimal QtyOnhand { get; set; }
        public decimal StockCostValue { get; set; }
        public decimal LastPurPrice { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
