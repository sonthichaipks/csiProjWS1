using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csiWSGeniuzPOS.Model
{
    public partial class VpsMember
    {
        public int Id { get; set; }
        public string MbId { get; set; }
        public string MbType { get; set; }
        public string MbNameT { get; set; }
        public string MbNameE { get; set; }
        public string MbAddress { get; set; }
        public string MbProvince { get; set; }
        public string MbAmphur { get; set; }
        public string MbTumbol { get; set; }
        public string MbZipCode { get; set; }
        public string MbLineAddr1 { get; set; }
        public string MbLineAddr2 { get; set; }
        public string MbLineAddr3 { get; set; }
        public string MbPid { get; set; }
        public string MbTelNo { get; set; }
        public string MbEmail { get; set; }
        public string MbGender { get; set; }
        public string MbNation { get; set; }
        public string MbRace { get; set; }
        public string MbOccupation { get; set; }
        public DateTime MbBirthDay { get; set; }
        public string MbCardType { get; set; }
        public DateTime MbApplyDate { get; set; }
        public DateTime MbExpireDate { get; set; }
        public short MbCardStatus { get; set; }
        public string MbPhoto { get; set; }
        public decimal MbAccumPoint { get; set; }
        public decimal MbNearlyExpirePoint { get; set; }
        public DateTime MbExpirePointDate { get; set; }
        public string MemberTypeDesc { get; set; }
        public decimal MbDiscPs { get; set; }
        public Int16 SellUnitPriceNo { get; set; }
        public Int16 MbPriceFg { get; set; }
    }      
}
