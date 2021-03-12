using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaCheckActs
    {
        public int Key { get; set; }
        public int Keyitem { get; set; }
        public int Keyosn { get; set; }
        public string Snom { get; set; }
        public string Acttype { get; set; }
        public byte[] Act { get; set; }
        public DateTime? Actdate { get; set; }
        public string Actnumber { get; set; }
    }
}
