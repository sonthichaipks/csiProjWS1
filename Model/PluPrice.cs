using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PluPrice
    {
        public int Id { get; set; }
        public string PluCode { get; set; }
        public string PluDesc { get; set; }
        public string PluShortDesc { get; set; }
        public string ColorId { get; set; }
        public string SizeId { get; set; }
        public string ArticleStyle { get; set; }
        public string SupplCode { get; set; }
        public short AllowSaleOverStock { get; set; }
        public short StockFg { get; set; }
        public short MbDiscMethod     { get; set;     }

        public decimal MbDiscPs { get; set; }
        public short MbPriceFg { get; set; }
        public decimal QtyOnHand { get; set; }
        public decimal SellUnitRatio { get; set; }
        public string PromoId { get; set; }
        public decimal BasePriceByPos { get; set; }

        public short BasePriceByPoSpriceNo { get; set; }
        public decimal GpNormal        {            get; set;        }
        public decimal GpPromo        {            get; set;        }

        public string MbId { get; set; }
        public short MbPriceNo { get; set; }
        public decimal MbPrice        {          get; set;        }
        public string PromoDay { get; set; }
        public decimal PromoPrice        {            get; set;        }
    }
}