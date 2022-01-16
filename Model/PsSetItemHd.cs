using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsSetItemHd
    {
        public int Id { get; set; }
        public string SetItemCode { get; set; }
        public string SetItemName { get; set; }
        public string SetItemShortName { get; set; }
        public string SetItemUnit { get; set; }
        public decimal SetPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
