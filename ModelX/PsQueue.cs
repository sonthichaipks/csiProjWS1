using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsQueue
    {
        public string ShopId { get; set; }
        public DateTime TodayDate { get; set; }
        public int LastQueueNo { get; set; }
        public int Id { get; set; }
    }
}
