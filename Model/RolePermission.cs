using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class RolePermission
    {
        public long RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public string PermissionKey { get; set; }
    }
}
