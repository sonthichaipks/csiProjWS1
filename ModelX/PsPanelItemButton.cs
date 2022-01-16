using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsPanelItemButton
    {
        public string TouchPanelType { get; set; }
        public short GroupButtonId { get; set; }
        public string ItemButtonId { get; set; }
        public string ItemButtonLabel { get; set; }
        public string LinkCode { get; set; }
        public short LinkCodeFg { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
