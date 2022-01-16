using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public class getPosTranHd
    {
        public int? Id { get; set; }
        public string DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DocTime { get; set; }
        public string RefDocNo { get; set; }
        public string PosId { get; set; }
        public string CashierId { get; set; }
        public string MbId { get; set; }
        public string SalesmanId { get; set; }
        public string SalesVatType { get; set; }

        public decimal GrossSales { get; set; }
        public decimal AllItemDiscount { get; set; }
        public decimal AllItemCharge { get; set; }
        public decimal BillDiscount { get; set; }
        public decimal NetSales { get; set; }
        public decimal BillCharge { get; set; }
        public decimal DocAmt { get; set; }
        public decimal Vat { get; set; }
        public decimal RoundAdjust { get; set; }
        public decimal NetSalesNormal { get; set; }
        public decimal NetSalesPromo { get; set; }
        public decimal NetSalesExVat { get; set; }
        public decimal NetSalesNonVat { get; set; }

        public decimal VatOfNetSales { get; set; }
        public decimal VatOfCharge { get; set; }
        public decimal ReceiveCash { get; set; }
        public decimal ReceiveCreditCd { get; set; }
        public decimal ReceiveDebitCd { get; set; }
        public decimal ReceiveCoupon { get; set; }
        public decimal ReceiveCashCd { get; set; }
        public decimal ReceivePoint { get; set; }
        public decimal ReceiveOthers { get; set; }
    }
}
