using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KonSmCh
    {
        public int IdSmCh { get; set; }
        public int IdAs { get; set; }
        public string SmCh { get; set; }
        public string Form { get; set; }
        public bool? Portret { get; set; }
        public byte[] DocKon { get; set; }
        public byte[] DocPr { get; set; }
        public int? IdKem { get; set; }
        public string NamIsh { get; set; }
        public byte[] DocDxf { get; set; }
        public int? IdSpec { get; set; }
        public DateTime? DateChange { get; set; }
    }
}
