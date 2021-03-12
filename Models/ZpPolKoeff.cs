using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpPolKoeff
    {
        public int Id { get; set; }
        public int IdPolog { get; set; }
        public string TypGood { get; set; }
        public int Vmin { get; set; }
        public int Vmax { get; set; }
        public decimal Kpr { get; set; }
        public decimal Smin { get; set; }
        public decimal Smax { get; set; }
    }
}
