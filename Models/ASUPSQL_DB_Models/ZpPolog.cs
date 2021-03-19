using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpPolog
    {
        public int Id { get; set; }
        public int IdIzgot { get; set; }
        public string NamPolog { get; set; }
        public string PathPolog { get; set; }
        public DateTime DateCh { get; set; }
        public string UserCh { get; set; }
        public string TypGood { get; set; }
        public int? Oklad { get; set; }
        public int? Doplata { get; set; }
    }
}
