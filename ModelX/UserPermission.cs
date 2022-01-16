using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class UserPermission
    {
        public long UserPermissionId { get; set; }
        public int UserId { get; set; }
        public string PermissionKey { get; set; }
        public bool Granted { get; set; }
    }
}
