using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KachKartDet
    {
        public DateTime? Data { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string Det { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public decimal? Kol { get; set; }
        public string NomKartPrv { get; set; }
        public decimal? NppOper { get; set; }
        public bool Delrecord { get; set; }
        public string NomKart { get; set; }
        public string ProductionNumber { get; set; }
        public decimal? RProd { get; set; }
    }
}
