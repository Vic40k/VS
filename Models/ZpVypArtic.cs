using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpVypArtic
    {
        public int Id { get; set; }
        public int IdIzgot { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Articul { get; set; }
        public string NamArtic { get; set; }
        public string Lit { get; set; }
        public string Group { get; set; }
        public decimal Price { get; set; }
        public int Kol { get; set; }
        public string Zp { get; set; }
        public decimal? PriceOld { get; set; }
        public decimal? PriceNew { get; set; }
    }
}
