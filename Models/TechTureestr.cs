using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechTureestr
    {
        public int IdRtu { get; set; }
        public string Det { get; set; }
        public string Kem { get; set; }
        public int IdIzgot { get; set; }
        public DateTime? DataSave { get; set; }
        public string Bai { get; set; }
        public string TuType { get; set; }
    }
}
