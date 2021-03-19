using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaKatOsn
    {
        public int Key { get; set; }
        public int? Nom { get; set; }
        public string Snom { get; set; }
        public bool? Ownproduction { get; set; }
        public decimal? Price { get; set; }
        public bool? Maintool { get; set; }
        public string Name { get; set; }
        public int? Checkperiod { get; set; }
        public bool? Composite { get; set; }
        public string SnomAsup { get; set; }
        public string Draftnumber1 { get; set; }
        public string Draftnumber2 { get; set; }
        public bool? Withoutcheck { get; set; }
        public bool? DeletedOs { get; set; }
        public byte? ProductionType { get; set; }
        public byte? CheckType { get; set; }
        public bool? Archive { get; set; }
    }
}
