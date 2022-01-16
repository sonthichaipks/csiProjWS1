using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{


    public class getPosTranReceipt
    {
        public int? Id { get; set; }
        public string DocNo { get; set; }
        public Int16 LineItemNo { get; set; }
        public Int16 PaymentType { get; set; }
        public decimal ReceiptAmt { get; set; }
        public string RefType { get; set; }
        public string RefNo { get; set; }

        public Int16 PointBurn { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyAmt { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
