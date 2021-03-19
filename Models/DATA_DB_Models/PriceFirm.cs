using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PriceFirm
    {
        public int RecordId { get; set; }
        public int SafeId { get; set; }
        public decimal PriceМтк { get; set; }
        public decimal PriceОоо { get; set; }
        public decimal PriceКон { get; set; }
        public decimal PriceДиал { get; set; }
    }
}
