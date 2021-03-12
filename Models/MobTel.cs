using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MobTel
    {
        public int IdRec { get; set; }
        public int? IdIzgot { get; set; }
        public string Operator { get; set; }
        public string Tnum { get; set; }
        public string Tsim { get; set; }
        public string Tpin { get; set; }
        public string Tpuk { get; set; }
        public int? IdOrg { get; set; }
    }
}
