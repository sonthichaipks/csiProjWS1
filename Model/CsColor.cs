using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsColor
    {
        public int Id { get; set; }
        public string ColorId { get; set; }
        public string ColorName { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
