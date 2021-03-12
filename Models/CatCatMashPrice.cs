using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CatCatMashPrice
    {
        public int IdPrice { get; set; }
        public int IdStat { get; set; }
        public string Prim { get; set; }
        public int Persent { get; set; }
        public decimal Price { get; set; }
        public string Bai { get; set; }
        public DateTime DataIzm { get; set; }
        public int IdMash { get; set; }
    }
}
