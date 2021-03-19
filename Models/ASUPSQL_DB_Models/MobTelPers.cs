using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MobTelPers
    {
        public int IdReg { get; set; }
        public int? IdPers { get; set; }
        public int? IdTel { get; set; }
        public decimal? LimitAbon { get; set; }
        public decimal? LimitTalk { get; set; }
    }
}
