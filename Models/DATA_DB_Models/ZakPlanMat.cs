using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ZakPlanMat
    {
        public int IdIzgot { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Det { get; set; }
        public string Mat { get; set; }
        public string Litera { get; set; }
        public decimal? Kol { get; set; }
        public string Bai { get; set; }
        public DateTime? DateIzm { get; set; }
        public string EdIzm { get; set; }
        public string Kod1C { get; set; }
        public decimal? Koeff1C { get; set; }
    }
}
