using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsDebitCard
    {
        public string DebitCardType { get; set; }
        public string DebitCardName { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
