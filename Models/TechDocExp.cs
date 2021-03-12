using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechDocExp
    {
        public string Bai { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DateB { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string Doc { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public bool Delrecord { get; set; }
        public int Idsegment { get; set; }
    }
}
