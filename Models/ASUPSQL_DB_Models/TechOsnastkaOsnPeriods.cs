using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaOsnPeriods
    {
        public int Key { get; set; }
        public byte Stage { get; set; }
        public int Keyobject { get; set; }
        public int Statuskod { get; set; }
        public int? Perioddays { get; set; }
        public DateTime? Datebeginfact { get; set; }
        public DateTime? Dateperformfact { get; set; }
        public int? Keyuser { get; set; }
        public int Sort { get; set; }
        public bool? Completed { get; set; }
        public bool? Done { get; set; }
    }
}
