using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class AndPlaning
    {
        public int Idrec { get; set; }
        public int MonthPlan { get; set; }
        public int Idizgot { get; set; }
        public string Kodizgot { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int ShiftCount { get; set; }
    }
}
