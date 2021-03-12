using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KonBzBau
    {
        public decimal? AsVvod { get; set; }
        public decimal? AsVyvod { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string Det { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public decimal? KodSb { get; set; }
        public decimal? KodSt { get; set; }
        public decimal? KolZb { get; set; }
        public string Lit { get; set; }
        public string NamDoc { get; set; }
        public decimal? PosSb { get; set; }
        public decimal? Rec { get; set; }
        public string Uzel { get; set; }
        public bool Delrecord { get; set; }
        public int? Idspec { get; set; }
    }
}
