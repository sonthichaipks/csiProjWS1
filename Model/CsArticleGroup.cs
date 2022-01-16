using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsArticleGroup
    {
        public int Id { get; set; }
        public string ArticleCode { get; set; }
        public string AtcGroupTypeCode { get; set; }
        public string AtcGroupCode { get; set; }
    }
}
