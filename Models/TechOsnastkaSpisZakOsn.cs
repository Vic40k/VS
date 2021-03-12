using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaSpisZakOsn
    {
        public int Key { get; set; }
        public int Keyosn { get; set; }
        public int Nomzak { get; set; }
        public string Datezak { get; set; }
        public string Nomosn { get; set; }
        public int? Kol { get; set; }
        public string Datesdat { get; set; }
        public int? Status { get; set; }
        public string Bai { get; set; }
        public bool? Alternatesstatus { get; set; }
        public bool? Completed { get; set; }
        public DateTime? Datecompletion { get; set; }
        public int Idizgot { get; set; }
        public int? Constructor { get; set; }
        public int? Performerstep8 { get; set; }
        public int Creator { get; set; }
    }
}
