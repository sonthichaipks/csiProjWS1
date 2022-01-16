using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csiWSGeniuzPOS.Model
{
    public partial class Vexchange
    {
        public int? Id { get; set; }
        public string CurrencyCode { get; set; }

        public string CurrencyName { get; set; }

        public DateTime EffectiveDate { get; set; }

        public decimal ExchangeRate { get; set; }
    }

}
