using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.ModelX
{
    public partial class PsPosShiftControl
    {
        public DateTime SingInDate { get; set; }
        public DateTime SingInTime { get; set; }
        public DateTime SingOutDate { get; set; }
        public DateTime SingOutTime { get; set; }
        public string ShiftStatus { get; set; }
        public string PosId { get; set; }
        public string CashierId { get; set; }
        public string StartReceiptNo { get; set; }
        public string EndReceiptNo { get; set; }
        public string StartRefundNo { get; set; }
        public string EndRefundNo { get; set; }
        public decimal BegCash { get; set; }
        public decimal CashIn { get; set; }
        public decimal CashOut { get; set; }
        public decimal CashSales { get; set; }
        public decimal RoundReceive { get; set; }
        public decimal CashBalance { get; set; }
        public decimal GrossAmt { get; set; }
        public decimal Deiscount { get; set; }
        public decimal NetSales { get; set; }
        public decimal Charge { get; set; }
        public decimal RecvByCash { get; set; }
        public decimal RecvByCoupon { get; set; }
        public decimal RecvByCreditCd { get; set; }
        public decimal RecvByDebitCd { get; set; }
        public decimal RecvByPoint { get; set; }
        public decimal RecvByCashCd { get; set; }
        public decimal RecvByOthers { get; set; }
        public short CountVoid { get; set; }
        public short CountCancel { get; set; }
        public short CountOpenDrawer { get; set; }
        public short CountCashIn { get; set; }
        public short CountCashOut { get; set; }
        public short CountRefund { get; set; }
        public decimal TotalVoidAmt { get; set; }
        public decimal TotalCashInAmt { get; set; }
        public decimal TotalCashOutamt { get; set; }
        public decimal TotalRefundAmt { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
    }
}
