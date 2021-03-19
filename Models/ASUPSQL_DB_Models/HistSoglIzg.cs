using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HistSoglIzg
    {
        public int IdKem { get; set; }
        public int IdSoglIzgot { get; set; }
        public DateTime? DataSogl { get; set; }
        public int? IdSogl { get; set; }
        public int? TypSogl { get; set; }
    }
}
