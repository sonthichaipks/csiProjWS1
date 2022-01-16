using System;
using System.Collections.Generic;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class PsShop
    {
        public int Id { get; set; }
        public string ShopId { get; set; }
        public string ShopTypeId { get; set; }
        public string ShopGroupId { get; set; }
        public string ShopName { get; set; }
        public string BranchName { get; set; }
        public string ShopAddress { get; set; }
        public string ShopRegName { get; set; }
        public string ShopRegAddressLine1 { get; set; }
        public string ShopRegAddressLine2 { get; set; }
        public string ShopRegAddressLine3 { get; set; }
        public string ShopRegId { get; set; }
        public string ShopTaxId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
