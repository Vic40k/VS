using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ArtArticulExt
    {
        public string Articul { get; set; }
        public int DopCod { get; set; }
        public int Idizgot { get; set; }
        public decimal? Labor { get; set; }
        public decimal? Weight { get; set; }
        public int Idrec { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Username { get; set; }
    }
}
