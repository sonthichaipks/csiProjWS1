using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{

    public class getPosTranDisc
    {
        public int? Id { get; set; }
        public string DocNo { get; set; }
        public Int16 LineItemNo { get; set; }
        public string LineItemType { get; set; }
        public decimal DiscPc { get; set; }
        public decimal DiscAmt { get; set; }
        public string DiscCouponType { get; set; }
        public string DiscCouponNo { get; set; }
        public string PromoId { get; set; }
        public decimal ChargePc { get; set; }
        public decimal ChargeAmt { get; set; }
    }
}
