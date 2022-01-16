using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class IcWh
    {
        public int Id { get; set; }
        public string WhsId { get; set; }
        public string WhsName { get; set; }
        public short WhsType { get; set; }
        public string ShopId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
