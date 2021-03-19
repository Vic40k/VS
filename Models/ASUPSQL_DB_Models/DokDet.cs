using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class DokDet
    {
        public string Det { get; set; }
        public byte[] DataFile { get; set; }
        public string ExtFile { get; set; }
        public string Bai { get; set; }
        public DateTime? DateChange { get; set; }
        public string NamDoc { get; set; }
        public int Id { get; set; }
        public int? IdIzgot { get; set; }
    }
}
