using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model

{
    public class getActivePosStation
    {
        public int? Id { get; set; }
        public string posId { get; set; }
        public string posPermitNo { get; set; }
        public string shopId { get; set; }
        public string branchName { get; set; }
        public string whsId { get; set; }
        public decimal lastReceiptRunNo { get; set; }
        public decimal lastRefundRunNo { get; set; }
        public short cashierPosFg { get; set; }
        public string posScreenType { get; set; }
        public string posTouchPanelId { get; set; }
        public decimal maxCashInDrawer { get; set; }
        public short autoChargeFg { get; set; }
        public decimal autoChargeRate { get; set; }
        public short mandatorySalesmanFg { get; set; }
        public short mandatoryMemberFg { get; set; }
        public string cashierId { get; set; }
        public string shiftStatus { get; set; }
        public DateTime singInTime { get; set; }
        public short nwType { get; set; }   
        public string nw_Ip { get; set; }
        public short nw_Command { get; set; }
        public short security_Auth { get; set; }
        public string security_Ref1 { get; set; }
        public string security_Ref2 { get; set; }
      
    }
}
