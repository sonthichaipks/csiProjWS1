using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsPromoHd
    {
        public int Id { get; set; }
        public string PromoId { get; set; }
        public string PromoName { get; set; }
        public string PromoDesc { get; set; }
        public DateTime StartPromoDate { get; set; }
        public DateTime EndPromoDate { get; set; }
        public short PromoTimeFg { get; set; }
        public DateTime StartPromoTime { get; set; }
        public DateTime EndPromoTime { get; set; }
        public short PromoDayFg { get; set; }
        public string PromoDay { get; set; }
        public short PromoCustFg { get; set; }
        public short PromoApproveFg { get; set; }
        public short PromoStatus { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
