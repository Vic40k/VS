using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpParam
    {
        public int Id { get; set; }
        public string NamParam { get; set; }
        public int EdTab { get; set; }
        public int RowParam { get; set; }
        public int ColParam { get; set; }
        public int IdBsc { get; set; }
        public string PageParam { get; set; }
        public int Prirost { get; set; }
        public int Kpr { get; set; }
    }
}
