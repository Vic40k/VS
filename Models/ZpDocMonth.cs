using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpDocMonth
    {
        public int Id { get; set; }
        public int EdTab { get; set; }
        public int IdDoc { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int? Sum { get; set; }
        public int Priznak { get; set; }
    }
}
