using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpItog
    {
        public int Id { get; set; }
        public int EdTab { get; set; }
        public int IdIzgot { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string F { get; set; }
        public string I { get; set; }
        public string O { get; set; }
        public decimal? NachAsup { get; set; }
        public decimal? Nach1C { get; set; }
        public decimal? PrDop { get; set; }
        public decimal? DopOtp { get; set; }
        public string CatRab { get; set; }
        public decimal? Dotp { get; set; }
        public decimal? Dbol { get; set; }
        public decimal? Dsoc { get; set; }
        public decimal? UdStol { get; set; }
        public decimal? UdMs { get; set; }
        public decimal? UdPr { get; set; }
        public decimal? UdNdfl { get; set; }
        public string KodIzgot { get; set; }
        public string OppAup { get; set; }
        public string Dolg { get; set; }
        public decimal? Kompens { get; set; }
    }
}
