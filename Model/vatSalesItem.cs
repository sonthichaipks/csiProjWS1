using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model

{
    public class vatSalesItem
    {
        public int? Id { get; set; }
        public string DocNo { get; set; }
        public decimal ExSales { get; set; }
        public decimal AlloDisc { get; set; }
        public decimal NetSales { get; set; }
        public decimal VatBillExClude { get; set; }
        public decimal VatCharge { get; set; }
    }

 
}
