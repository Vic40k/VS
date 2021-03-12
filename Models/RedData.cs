using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class RedData
    {
        public string SmCh { get; set; }
        public byte[] DocPr { get; set; }
        public string Bai { get; set; }
        public DateTime? DateChange { get; set; }
        public int? IdSpec { get; set; }
        public byte[] DocKon { get; set; }
        public byte[] DocDxf { get; set; }
    }
}
