using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MobPerView
    {
        public int IdPers { get; set; }
        public int? IdReg { get; set; }
        public string Fio { get; set; }
        public int? IdOrg { get; set; }
    }
}
