using System;
using System.Collections.Generic;

namespace csiWSGeniuzPOS.Model
{
    public partial class PaymentInfo
    {
        public int? Id { get; set; }
        public string paytype { get; set; }
        public string code { get; set; }
        public string detail { get; set; }
        public int valuetype { get; set; }
        public decimal value { get; set; }
        public decimal pcamt { get; set; }
        public decimal pcpc { get; set; }
        
    }
}
