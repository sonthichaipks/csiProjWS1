using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsMbDiscGroup
    {
        public string MemberType { get; set; }
        public string GroupTypeCode { get; set; }
        public string GroupCode { get; set; }
        public decimal MbDiscPs { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
