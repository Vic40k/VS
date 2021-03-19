using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechDetIzm
    {
        public string Mat { get; set; }
        public decimal? Price { get; set; }
        public decimal? Ob { get; set; }
        public string Smch { get; set; }
        public string Det { get; set; }
        public decimal? As { get; set; }
        public string Dbenennung { get; set; }
        public decimal? AsSmchMaxOld { get; set; }
        public decimal? AsSmchMaxNew { get; set; }
        public decimal? AsMaxNew { get; set; }
        public decimal? AsMaxOld { get; set; }
        public string Typework { get; set; }
        public decimal? AsSmchMax { get; set; }
        public string IsDocDxf { get; set; }
        public string RazData { get; set; }
        public string Kem { get; set; }
        public int? IdIzgot { get; set; }
        public int? KemIdSpec { get; set; }
        public string KemDet { get; set; }
        public string Kemart { get; set; }
        public string Kemnam { get; set; }
        public int? KemIdGood { get; set; }
        public DateTime? KemDataSt { get; set; }
        public DateTime? KemDataFin { get; set; }
        public int? KemIdIzgot { get; set; }
        public int? KemNewIzd { get; set; }
        public string Typeizm { get; set; }
    }
}
