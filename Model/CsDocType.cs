using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsDocType
    {
        public int Id { get; set; }
        public string DocType { get; set; }
        public string DocName { get; set; }
        public string DocPrefix { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
