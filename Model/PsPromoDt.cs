using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsPromoDt
    {
        public int Id { get; set; }
        public string PromoId { get; set; }
        public short ItemType { get; set; }
        public string ItemCode { get; set; }
        public short PromoType { get; set; }
        public decimal PromoDiscPc { get; set; }
        public decimal PromoPrice { get; set; }
        public decimal GpNormal { get; set; }
        public decimal GpPromo { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
