using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class RedSpecReestr
    {
        public int IdSpec { get; set; }
        public string Det { get; set; }
        public string TypCh { get; set; }
        public byte[] FilePr { get; set; }
        public string ExtPr { get; set; }
        public byte[] FileOn { get; set; }
        public string ExtOn { get; set; }
        public byte[] FileEng { get; set; }
        public string ExtEng { get; set; }
        public int AsCh { get; set; }
    }
}
