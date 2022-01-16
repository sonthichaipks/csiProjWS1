using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsMemberType
    {
        public string MemberType { get; set; }
        public string MemberTypeDesc { get; set; }
        public decimal MbDiscPs { get; set; }
        public short SellUnitPriceNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public short? MbPriceFg { get; set; }
        public int Id { get; set; }
    }
}
