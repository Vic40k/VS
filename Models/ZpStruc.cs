using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpStruc
    {
        public int Id { get; set; }
        public int IdIzgot { get; set; }
        public string KodPar { get; set; }
        public string KodIzgot { get; set; }
        public string Nam { get; set; }
        public int? Lider { get; set; }
        public int? Utv { get; set; }
        public string Vis { get; set; }
        public decimal? Proc { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Status { get; set; }
    }
}
