using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakKodIzgot
    {
        public int Id { get; set; }
        public string NSub { get; set; }
        public string Articul { get; set; }
        public string KodIzgot { get; set; }
        public string DopCod { get; set; }
        public int IdIzgot { get; set; }
    }
}
