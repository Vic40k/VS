using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MetStockflow
    {
        public int Idrec { get; set; }
        public DateTime Datsavesql { get; set; }
        public int ObjectId { get; set; }
        public int ObjectFormat { get; set; }
        public int Tab { get; set; }
        public string Operation { get; set; }
        public string TargetKodizgot { get; set; }
        public int? Birk { get; set; }
        public int? Count { get; set; }
        public decimal? Weight { get; set; }
        public int Idizgot { get; set; }
        public bool Delrecord { get; set; }
    }
}
