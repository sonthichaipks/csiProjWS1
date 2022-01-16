using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsPara
    {
        public string ShopName { get; set; }
        public string BranchName { get; set; }
        public string ShopAddress { get; set; }
        public string ShopRegName { get; set; }
        public string ShopRegAddressLine1 { get; set; }
        public string ShopRegAddressLine2 { get; set; }
        public string ShopRegAddressLine3 { get; set; }
        public string ShopRegId { get; set; }
        public string ShopTaxId { get; set; }
        public decimal ChargeVatRate { get; set; }
        public string PosProcessMode { get; set; }
        public string PosScreenType { get; set; }
        public string WeightBarcodePrefix { get; set; }
        public decimal PointRedeemOneBaht { get; set; }
        public short DiscRoundMethod { get; set; }
        public short CashPayRoundMethod { get; set; }
        public string ShopLogoOnFrontScreen { get; set; }
        public string ShopLogoOnReceipt { get; set; }
        public string RecptHeadMesg1 { get; set; }
        public string RecptHeadMesg2 { get; set; }
        public string RecptHeadMesg3 { get; set; }
        public string RecptHeadMesg4 { get; set; }
        public string RecptHeadMesg5 { get; set; }
        public string RecptHeadMesg6 { get; set; }
        public string RecptFootMesg1 { get; set; }
        public string RecptFootMesg2 { get; set; }
        public string RecptFootMesg3 { get; set; }
        public string RecptFootMesg4 { get; set; }
        public string RecptFootMesg5 { get; set; }
        public string RecptFootMesg6 { get; set; }
        public string RecptFootMesg7 { get; set; }
        public string RecptFootMesg8 { get; set; }
        public string RecptFootMesg9 { get; set; }
        public string RecptFootMesg10 { get; set; }
        public short RecptNoBarcodeFg { get; set; }
        public short SelectSellingPriceFg { get; set; }
        public short ReceiptPrinterType { get; set; }
        public short SalesDocFg { get; set; }
        public string SalesVatType { get; set; }
        public short EjournalFg { get; set; }
        public decimal NoOfRecptCopy { get; set; }
        public short PrintOrderFg { get; set; }
        public short PrintQueueFg { get; set; }
        public short ItemOnRecptMethod { get; set; }
        public short RecptSumItemQtyFg { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public short? MbDiscMethod { get; set; }
        public int Id { get; set; }
        public int? AllowSaleOverStock { get; set; }
    }
}
