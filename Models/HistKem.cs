using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HistKem
    {
        public int IdHist { get; set; }
        public int IdIzgot { get; set; }
        public string Kem { get; set; }
        public DateTime? DataSt { get; set; }
        public DateTime? DataFin { get; set; }
        public string Post { get; set; }
        public string Osnov { get; set; }
        public int? Sogl { get; set; }
        public int IdUser { get; set; }
        public int? IdUtv { get; set; }
        public DateTime? DataSogl { get; set; }
        public int? Ukazanie { get; set; }
        public int? Krug { get; set; }
        public int? IdKartRaz { get; set; }
    }
}
