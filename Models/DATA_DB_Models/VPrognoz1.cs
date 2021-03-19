using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class VPrognoz1
    {
        public string ArticulTo { get; set; }
        public decimal? Sweek1 { get; set; }
        public decimal? Sweek2 { get; set; }
        public decimal? Smonth1 { get; set; }
        public decimal? Smonth2 { get; set; }
        public decimal? Smonth3 { get; set; }
        public decimal? Smonth4 { get; set; }
        public string EdIzm { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int Factory { get; set; }
    }
}
