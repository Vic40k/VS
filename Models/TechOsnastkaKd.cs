using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaKd
    {
        public int Key { get; set; }
        public int Keyosn { get; set; }
        public DateTime? DateKd { get; set; }
        public string Bai { get; set; }
        public decimal? As { get; set; }
        public byte[] Kd { get; set; }
        public string FilenameKd { get; set; }
        public string Note { get; set; }
        public byte DocumentType { get; set; }
    }
}
