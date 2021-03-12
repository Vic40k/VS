using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpPers
    {
        public int IdRec { get; set; }
        public int IdCur { get; set; }
        public int? EdTab { get; set; }
        public string Firma { get; set; }
        public string KodIzgot { get; set; }
        public int? IdOrg { get; set; }
        public string Kat { get; set; }
        public bool LogZp { get; set; }
        public int TypZp { get; set; }
        public decimal? Summa { get; set; }
        public bool? LogItr { get; set; }
        public DateTime? DateUv { get; set; }
        public string Place { get; set; }
        public int? Kateg { get; set; }
    }
}
