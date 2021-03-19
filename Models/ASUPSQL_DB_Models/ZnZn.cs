using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZnZn
    {
        public int IdZn { get; set; }
        public int IdHead { get; set; }
        public int Priznak { get; set; }
        public string KodIzgot { get; set; }
        public int? Kol { get; set; }
    }
}
