using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class GraidZp
    {
        public int? IdProff { get; set; }
        public int? IdIzgot { get; set; }
        public decimal? Obzor { get; set; }
        public decimal? ZpMin { get; set; }
        public decimal? ZpMax { get; set; }
        public decimal? ZpMed { get; set; }
    }
}
