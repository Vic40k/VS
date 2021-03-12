using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechTusetup
    {
        public int? Statusid { get; set; }
        public string ToDo { get; set; }
        public string Done { get; set; }
        public string Role { get; set; }
        public bool? Mayclose1 { get; set; }
        public byte? Mayclose { get; set; }
        public int? IdIzgot { get; set; }
    }
}
