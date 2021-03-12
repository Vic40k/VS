using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakSvSp
    {
        public int IdRec { get; set; }
        public int IdGood { get; set; }
        public int IdMat { get; set; }
        public decimal? Kol { get; set; }
        public int IdIzgot { get; set; }
        public bool? Tp { get; set; }
    }
}
