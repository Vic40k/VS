using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KachKartMat
    {
        public DateTime? Datsavesql { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public decimal? KolMat { get; set; }
        public string Lit { get; set; }
        public string Mat { get; set; }
        public string NomKartPrv { get; set; }
        public decimal? PriceMat { get; set; }
        public decimal? PriceTim { get; set; }
        public decimal? Tim { get; set; }
        public bool Delrecord { get; set; }
        public string NomKart { get; set; }
        public int DetailListId { get; set; }
    }
}
