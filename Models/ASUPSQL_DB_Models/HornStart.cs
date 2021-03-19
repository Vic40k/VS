using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HornStart
    {
        public int IdHron { get; set; }
        public int IdFilial { get; set; }
        public string Dolg { get; set; }
        public string Fio { get; set; }
        public DateTime DateSave { get; set; }
        public int Interval { get; set; }
    }
}
