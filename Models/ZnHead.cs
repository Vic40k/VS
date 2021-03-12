using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZnHead
    {
        public int IdHead { get; set; }
        public string Izd { get; set; }
        public int Kol { get; set; }
        public string Zakaz { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int IdIzgot { get; set; }
        public DateTime DatSt { get; set; }
        public DateTime DatFin { get; set; }
    }
}
