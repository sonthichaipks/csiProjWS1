using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{

    public class getPosTranDt
    {
        public int? Id { get; set; }
        public string DocNo { get; set; }
        public Int16 LineItemNo { get; set; }
        public string LineItemType { get; set; }
        public Int16 RefLineItemNo { get; set; }
        public string PluCode { get; set; }
        public decimal Qty { get; set; }
        public string SerialNo { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExPrice { get; set; }
        public decimal DiscPc { get; set; }
        public decimal Discamt { get; set; }
        public string DiscCouponType { get; set; }
        public string DiscCouponNo { get; set; }
        public string PromoId { get; set; }
        public decimal ChargePc { get; set; }
        public decimal ChargeAmt { get; set; }
        public string ItemVatType { get; set; }
        public Int16 ItemPromoFg { get; set; }
        public string ItemPromoId { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal ItemCharge { get; set; }
        public decimal ItemNetExprice { get; set; }
        public decimal AllocatedBillDiscount { get; set; }
        public decimal ItemNetSales { get; set; }
        public decimal ItemVatRate { get; set; }
        public decimal ItemVat { get; set; }
        public string ItemDesc { get; set; }
        public decimal QtyRefund { get; set; }
    }
}
