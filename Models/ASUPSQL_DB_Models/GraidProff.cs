using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class GraidProff
    {
        public int IdProff { get; set; }
        public string KodProff { get; set; }
        public string KrNam { get; set; }
        public string ProffNam { get; set; }
        public string ProffDiscr { get; set; }
        public int? Ball1 { get; set; }
        public int? Ball2 { get; set; }
        public int? Ball3 { get; set; }
        public int? Ball4 { get; set; }
        public int? Ball5 { get; set; }
        public int? Ball6 { get; set; }
        public bool? Flag { get; set; }
        public decimal? Obzor { get; set; }
        public decimal? ZpMax { get; set; }
        public decimal? ZpMin { get; set; }
        public decimal? ZpMed { get; set; }
    }
}
