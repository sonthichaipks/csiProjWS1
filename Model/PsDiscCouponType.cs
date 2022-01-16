using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsDiscCouponType
    {
        public int Id { get; set; }
        public string DiscCouponType { get; set; }
        public string DiscCouponName { get; set; }
        public short DiscCouponValueType { get; set; }
        public decimal DiscCouponValue { get; set; }
        public decimal PartnerCompensateAmt { get; set; }
        public decimal PartnerCompensatePc { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
