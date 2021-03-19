using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CatMash
    {
        public int Idmash { get; set; }
        public int? Inv { get; set; }
        public string Nam { get; set; }
        public DateTime Datavv { get; set; }
        public DateTime? Datavyv { get; set; }
        public int Idob { get; set; }
        public string Bai { get; set; }
        public DateTime? DataIzm { get; set; }
        public decimal? Price { get; set; }
        public int Idizgot { get; set; }
        public string ZavNom { get; set; }
        public string Prim { get; set; }
    }
}
