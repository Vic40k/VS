using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakSpec
    {
        public int IdZak { get; set; }
        public int IdIzgot { get; set; }
        public string Order { get; set; }
        public string Customer { get; set; }
        public string Bai { get; set; }
        public DateTime DataOpen { get; set; }
        public string NsubAsup { get; set; }
        public DateTime? DataFinish { get; set; }
        public DateTime? DataPlan { get; set; }
        public int Priznak { get; set; }
        public bool? FlagCh { get; set; }
        public string Addition { get; set; }
    }
}
