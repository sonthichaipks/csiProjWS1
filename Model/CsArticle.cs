using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class CsArticle
    {
        public int Id { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleStyle { get; set; }
        public string ArticleName { get; set; }
        public string ArticleDesc { get; set; }
        public string ArticleDesc2 { get; set; }
        public string SupplCode { get; set; }
        public string VatType { get; set; }
        public string VatRateCode { get; set; }
        public string BaseUnit { get; set; }
        public DateTime? MarketDate { get; set; }
        public string ProdImageLink { get; set; }
        public short ConsignFg { get; set; }
        public decimal ConsignGp { get; set; }
        public short ActivePurFg { get; set; }
        public short ActiveSellFg { get; set; }
        public short ActiveRepFg { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
