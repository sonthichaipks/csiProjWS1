using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PmUnitPrice
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string PromoId { get; set; }
        public string PromoName { get; set; }
        public string PromoDesc { get; set; }
        public short PromoStatus { get; set; }
        public short PromoApproveFg { get; set; }
        public short PromoDayFg { get; set; }
        public string PromoDay { get; set; }
        public short PromoCustFg { get; set; }
        public short PromoType { get; set; }
        public decimal PromoPrice { get; set; }
        public decimal PromoDiscPc { get; set; }
        public decimal GpNormal { get; set; }
        public decimal GpPromo { get; set; }
        public short BasePriceByPoSpriceNo { get; set; }
        public decimal BasePriceByPos { get; set; }
        public decimal ProPriceByPriceNo { get; set; }
        public decimal ProPriceByDisc { get; set; }
        public string MbId { get; set; }
        public short mbPriceNo { get; set; }
        public decimal MbPrice { get; set; }
      

    }
}
