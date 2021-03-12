using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZnEdTabNorm
    {
        public int Id { get; set; }
        public int IdZn { get; set; }
        public int EdTab { get; set; }
        public decimal TimNorm { get; set; }
        public decimal Tarif { get; set; }
        public decimal Prem { get; set; }
        public decimal Ktu { get; set; }
    }
}
