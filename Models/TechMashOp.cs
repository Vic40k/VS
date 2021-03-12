using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechMashOp
    {
        public string Bai { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Datsavesql { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string Mash { get; set; }
        public string Operaciya { get; set; }
        public bool? PrTime { get; set; }
        public bool? Priz { get; set; }
        public decimal? Tim { get; set; }
        public bool? Tool { get; set; }
        public bool Delrecord { get; set; }
    }
}
