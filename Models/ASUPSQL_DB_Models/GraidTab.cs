using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class GraidTab
    {
        public int IdGr { get; set; }
        public string NamGrKr { get; set; }
        public string DiscrGr { get; set; }
        public int? Bal { get; set; }
    }
}
