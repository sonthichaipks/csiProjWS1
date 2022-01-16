﻿using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class CsDocGroup
    {
        public string DocType { get; set; }
        public string DocGroup { get; set; }
        public string DocGroupDesc { get; set; }
        public string PrintFormName { get; set; }
        public string DocFormTitleT { get; set; }
        public string DocFormTitleE { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
