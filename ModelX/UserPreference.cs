using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class UserPreference
    {
        public int UserPreferenceId { get; set; }
        public long UserId { get; set; }
        public string PreferenceType { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
