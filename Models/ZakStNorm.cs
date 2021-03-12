using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakStNorm
    {
        public string Articul { get; set; }
        public string Bai { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string EdIzm { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public decimal? KolNal { get; set; }
        public decimal? KolPotr { get; set; }
        public decimal? KolZak { get; set; }
        public string Lit { get; set; }
        public string Nam { get; set; }
        public string Norm { get; set; }
        public decimal? Price { get; set; }
        public string Prim { get; set; }
        public bool Delrecord { get; set; }
    }
}
