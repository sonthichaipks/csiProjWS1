using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsPanelItemButton
    {
        public int Id { get; set; }
        public string TouchPanelType { get; set; }
        public short GroupButtonId { get; set; }
        public short ItemButtonId { get; set; }
        public string ItemButtonLabel { get; set; }
        public string ItemButtonImage { get; set; }
        public string LinkCode { get; set; }
        public short LinkCodeFg { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string BgColor { get; set; }
        public string TxtColor { get; set; }
        public decimal TxtFontSize { get; set; }
    }
}
