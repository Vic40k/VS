using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class VPrognozSafePr
    {
        public string ArticulTo { get; set; }
        public decimal? Smonth1 { get; set; }
        public decimal? Smonth2 { get; set; }
        public decimal? Smonth3 { get; set; }
        public string EdIzm { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int Factory { get; set; }
        public int IdТовара { get; set; }
        public int Koeff1C { get; set; }
        public decimal? Kol { get; set; }
        public bool? Tp { get; set; }
        public int IdTmcPost { get; set; }
    }
}
