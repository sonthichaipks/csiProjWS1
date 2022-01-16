using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsMemberType
    {
        public int Id { get; set; }
        public string MemberType { get; set; }
        public string MemberTypeDesc { get; set; }
        public decimal MbDiscPs { get; set; }
        public short SellUnitPriceNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
