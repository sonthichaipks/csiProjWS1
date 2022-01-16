using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsPosStation
    {
        public string PosId { get; set; }
        public string PosPermitNo { get; set; }
        public string ShopId { get; set; }
        public string WhsId { get; set; }
        public decimal LastReceiptRunNo { get; set; }
        public decimal LastRefundRunNo { get; set; }
        public short CashierPosFg { get; set; }
        public string PosScreenType { get; set; }
        public string PosTouchPanelId { get; set; }
        public decimal MaxCashInDrawer { get; set; }
        public short AutoChargeFg { get; set; }
        public decimal AutoChargeRate { get; set; }
        public short MandatorySalesmanFg { get; set; }
        public short MandatoryMemberFg { get; set; }
        public short ConnectPrinterFg { get; set; }
        public short ConnectDrawerFg { get; set; }
        public short ConnectVfdfg { get; set; }
        public short Connect2ndDispFg { get; set; }
        public short ConnectEdcfg { get; set; }
        public short ConnectRfidreaderFg { get; set; }
        public short SellingPriceNo { get; set; }
        public short PsParaDefault1 { get; set; }
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
        public short PsParaDefault2 { get; set; }
        public short SelectSellingPriceFg { get; set; }
        public short ReceiptPrinterType { get; set; }
        public short SalesDocFg { get; set; }
        public string SalesVatType { get; set; }
        public short EjournalFg { get; set; }
        public short NoOfRecptCopy { get; set; }
        public short PrintOrderFg { get; set; }
        public short PrintQueueFg { get; set; }
        public short ItemOnRecptMethod { get; set; }
        public short RecptSumItemQtyFg { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
