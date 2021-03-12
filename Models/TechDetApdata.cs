using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechDetApdata
    {
        public string Det { get; set; }
        public int As { get; set; }
        public byte[] RazData { get; set; }
        public string Bai { get; set; }
        public DateTime? DateChange { get; set; }
        public string Ext { get; set; }
        public int? IdIzgot { get; set; }
        public bool? Pytool { get; set; }
        public bool? Informed { get; set; }
    }
}
