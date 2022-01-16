using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class DataAuditLog
    {
        public int LogId { get; set; }
        public short LogType { get; set; }
        public DateTime LogDate { get; set; }
        public int? UserId { get; set; }
        public string TableName { get; set; }
        public string RecordId { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
