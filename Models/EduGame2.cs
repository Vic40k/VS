using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EduGame2
    {
        public int IdTr { get; set; }
        public int Comp { get; set; }
        public int Smena { get; set; }
        public string Articul { get; set; }
        public int? KolZ { get; set; }
        public int? KolIz { get; set; }
        public int? KolPr { get; set; }
    }
}
