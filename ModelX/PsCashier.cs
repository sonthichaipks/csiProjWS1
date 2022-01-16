using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsCashier
    {
        public string CashierId { get; set; }
        public string CashierName { get; set; }
        public string CashierPassword { get; set; }
        public short CashierLevel { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
