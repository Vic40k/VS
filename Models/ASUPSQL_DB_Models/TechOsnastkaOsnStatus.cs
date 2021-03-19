using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaOsnStatus
    {
        public int Key { get; set; }
        public string Status { get; set; }
        public int? Statuskod { get; set; }
        public int? To { get; set; }
        public string Todo { get; set; }
        public string Redo { get; set; }
        public string Todotxt { get; set; }
        public int? Perioddays { get; set; }
        public byte Branch { get; set; }
        public string Status2 { get; set; }
        public string Todo2 { get; set; }
        public int? To2 { get; set; }
    }
}
