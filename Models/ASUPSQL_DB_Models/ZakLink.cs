using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakLink
    {
        public int IdRec { get; set; }
        public string NSub { get; set; }
        public string Lit { get; set; }
        public DateTime? DateSet { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateFin { get; set; }
        public int Status { get; set; }
        public int IdIzgot { get; set; }
    }
}
