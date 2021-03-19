using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HrPrFio
    {
        public DateTime? DataFin { get; set; }
        public DateTime? DataIsp { get; set; }
        public DateTime? DataPr { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string Fio { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string Log { get; set; }
        public string Prikaz { get; set; }
        public decimal? Summa { get; set; }
        public string Typ { get; set; }
        public bool Delrecord { get; set; }
    }
}
