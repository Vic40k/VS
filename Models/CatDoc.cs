using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CatDoc
    {
        public int IdDoc { get; set; }
        public string ExtDoc { get; set; }
        public string NamDoc { get; set; }
        public string Bai { get; set; }
        public DateTime DateDoc { get; set; }
        public byte[] DataDoc { get; set; }
    }
}
