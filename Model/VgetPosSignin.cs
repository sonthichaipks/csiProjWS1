using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csiWSGeniuzPOS.Model
{
    public class VgetPosSignin
    {
        public int? Id { get; set; }
        public string CashierId { get; set; }

        public string CashierName { get; set; }

        public string CashierPassword { get; set; }

       public int? CashierLevel { get; set; }

        public string ShopId { get; set; }
        public int CashierPosFg { get; set; }

        //  public DateTime SingInDate { get; set; }

        //   public DateTime SingInTime { get; set; }

        //   public DateTime SingOutDate { get; set; }

        //      public DateTime SingOutTime { get; set; }

        public string ShiftStatus { get; set; }

         public string PosId { get; set; }

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

        public int? CountVoid { get; set; }

        public int? CountCancel { get; set; }

        public int? CountOpenDrawer { get; set; }

        public int? CountCashIn { get; set; }

        public int? CountCashOut { get; set; }

        public int? CountRefund { get; set; }

        public decimal TotalVoidAmt { get; set; }

         public decimal TotalCashInAmt { get; set; }
      public decimal TotalCashOutamt { get; set; }

        public decimal TotalRefundAmt { get; set; }

        public int? posshiftID { get; set; }


        public string PromptPayLink { get; set; }
        public string QRCodeAccount { get; set; }
    }
}
