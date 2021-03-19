using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpVed
    {
        public int IdRec { get; set; }
        public int IdIzgot { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int EdTab { get; set; }
        public decimal? NachAsup { get; set; }
        public decimal? Nach1C { get; set; }
        public decimal? Dotp { get; set; }
        public string Kateg { get; set; }
        public decimal? OtpPr { get; set; }
        public decimal? BolPr { get; set; }
        public decimal? Dvoz { get; set; }
        public decimal? UdStol { get; set; }
        public decimal? UdMob { get; set; }
        public decimal? UdPr { get; set; }
        public decimal? Ndfl { get; set; }
        public int? IdOpp { get; set; }
        public int? IdSt { get; set; }
        public int? IdOrg { get; set; }
    }
}
