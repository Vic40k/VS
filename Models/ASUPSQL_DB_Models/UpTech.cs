using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class UpTech
    {
        public int IdZak { get; set; }
        public string UpCod { get; set; }
        public int? Kol { get; set; }
        public int? Priznak { get; set; }
        public string Bai { get; set; }
        public DateTime? DataChange { get; set; }
    }
}
