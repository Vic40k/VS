using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpSvod
    {
        public int Id { get; set; }
        public string Faktor { get; set; }
        public string FKr { get; set; }
        public int? Idizgot { get; set; }
        public string Podr { get; set; }
        public string Calc { get; set; }
        public string Format { get; set; }
        public decimal? Const { get; set; }
        public bool? Priznak { get; set; }
        public string EdIzm { get; set; }
    }
}
