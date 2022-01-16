using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsPosTouchPanelType
    {
        public int Id { get; set; }
        public string TouchPanelType { get; set; }
        public string POSScreenType { get; set; }
        public string TouchPanelDesc { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
