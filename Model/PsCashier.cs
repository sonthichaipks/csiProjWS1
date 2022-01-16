using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsCashier
    {
        public int Id { get; set; }
        public string CashierId { get; set; }
        public string CashierName { get; set; }
        public string CashierPassword { get; set; }
        public short CashierLevel { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
