using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsPosTranDisc
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public short LineItemNo { get; set; }
        public string LineItemType { get; set; }
        public string DiscCouponType { get; set; }
        public string DiscCouponNo { get; set; }
        public string PromoId { get; set; }
        public decimal ChargePc { get; set; }
        public decimal ChargeAmt { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
