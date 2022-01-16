using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsHoldDt
    {
        public string HoldNo { get; set; }
        public short LineItemNo { get; set; }
        public string LineItemType { get; set; }
        public string PluCode { get; set; }
        public decimal Qty { get; set; }
        public string SerialNo { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExPrice { get; set; }
        public decimal DiscPc { get; set; }
        public decimal DiscAmt { get; set; }
        public string CouponNo { get; set; }
        public string PromoId { get; set; }
        public decimal ChrgPc { get; set; }
        public decimal ChrgAmt { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
