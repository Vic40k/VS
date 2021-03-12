using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopIzgWhouse
    {
        public int IdRec { get; set; }
        public double LoadVolume { get; set; }
        public int ItemCount { get; set; }
        public double LoadWeight { get; set; }
        public int ComplexityClass { get; set; }
        public double ComplexityKoeff { get; set; }
    }
}
