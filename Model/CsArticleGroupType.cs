using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsArticleGroupType
    {
        public int Id { get; set; }
        public string AtcGroupTypeCode { get; set; }
        public string AtcGroupTypeDesc { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
