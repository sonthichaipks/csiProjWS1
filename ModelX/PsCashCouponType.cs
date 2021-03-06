using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsCashCouponType
    {
        public string CashCouponType { get; set; }
        public string CashCouponName { get; set; }
        public short CashCouponValueType { get; set; }
        public decimal CashCouponValue { get; set; }
        public decimal PartnerCompensateAmt { get; set; }
        public decimal PartnerCompensatePc { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
