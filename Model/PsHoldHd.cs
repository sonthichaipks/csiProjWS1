using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsHoldHd
    {
        public int Id { get; set; }
        public string HoldNo { get; set; }
        public DateTime HoldDate { get; set; }
        public string PosId { get; set; }
        public string CashierId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
