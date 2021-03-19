using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakNakArtDs
    {
        public string Articul { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string DopCod { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string Nakl { get; set; }
        public decimal? Smena { get; set; }
        public bool Delrecord { get; set; }
        public DateTime? Datat { get; set; }
    }
}
