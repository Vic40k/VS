using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MobCalcPay
    {
        public int IdRec { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? IdReg { get; set; }
        public decimal? UsP { get; set; }
        public decimal? UsR { get; set; }
        public decimal? UsTel { get; set; }
        public decimal? SummNds { get; set; }
        public int? IdOrg { get; set; }
    }
}
