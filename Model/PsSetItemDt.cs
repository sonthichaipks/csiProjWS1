﻿using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsSetItemDt
    {
        public int Id { get; set; }
        public string SetItemCode { get; set; }
        public string PluCode { get; set; }
        public decimal Qty { get; set; }
        public decimal NormalUnitPrice { get; set; }
        public decimal SetUnitPrice { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
