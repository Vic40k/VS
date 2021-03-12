using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class Prices44
    {
        public int Iditem { get; set; }
        public string Currency { get; set; }
        public decimal? FifoPrice { get; set; }
        public decimal? MiddlePrice { get; set; }
        public decimal? LifoPrice { get; set; }
        public decimal? FifoNds { get; set; }
        public decimal? MiddleNds { get; set; }
        public decimal? LifoNds { get; set; }
        public DateTime? DateLastUpdate { get; set; }
    }
}
