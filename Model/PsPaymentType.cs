using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsPaymentType
    {
        public int Id { get; set; }
        public short PaymentType { get; set; }
        public string PaymentName { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
