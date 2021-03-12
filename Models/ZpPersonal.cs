using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpPersonal
    {
        public int Id { get; set; }
        public int Oklad { get; set; }
        public int EdTab { get; set; }
        public decimal Kind { get; set; }
        public int Typ { get; set; }
        public string KodIzgot { get; set; }
        public int IdIzgot { get; set; }
        public decimal? Kkval { get; set; }
    }
}
