using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsPanelGroupButton
    {
        public string TouchPanelType { get; set; }
        public short GroupButtonId { get; set; }
        public string GroupButtonLabel { get; set; }
        public string GroupButtonImage { get; set; }
        public string LinkCode { get; set; }
        public short LinkCodeFg { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
