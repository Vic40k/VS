using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TmpConfig
    {
        public int IdIzgot { get; set; }
        public string Priznak { get; set; }
        public string Path { get; set; }
        public bool Log { get; set; }
        public DateTime? DataChange { get; set; }
    }
}
