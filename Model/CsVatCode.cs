using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsVatCode
    {
        public int Id { get; set; }
        public string VatRateCode { get; set; }
        public decimal VatRate { get; set; }
    }
}
