using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsPosTranRecv
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public short LineItemNo { get; set; }
        public short LineItemType { get; set; }
        public decimal ReceivetAmt { get; set; }
        public string RefType { get; set; }
        public string RefNo { get; set; }
        public short PointBurn { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyAmt { get; set; }
        public decimal ExchangeRate { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
