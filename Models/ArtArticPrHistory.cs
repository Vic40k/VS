using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ArtArticPrHistory
    {
        public int Idrec { get; set; }
        public string Articul { get; set; }
        public int DopCod { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Idizgot { get; set; }
        public decimal? Price { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Username { get; set; }
        public string Articulext { get; set; }
        public int Datecomp { get; set; }
    }
}
