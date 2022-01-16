using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsPosFunc
    {
        public string FuncId { get; set; }
        public string FuncDesc { get; set; }
        public short FunLevel { get; set; }
        public short FuncUsage { get; set; }
        public string KbMapShiftCode { get; set; }
        public string KbMapKeyCode { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
