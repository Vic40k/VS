using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class VВсеСборкиAsup
    {
        public int? IdТовара { get; set; }
        public string Articul { get; set; }
        public string Det { get; set; }
        public string PerentDet { get; set; }
        public decimal? Kol { get; set; }
        public string Lit { get; set; }
        public decimal? AsVvod { get; set; }
        public decimal? AsVyvod { get; set; }
        public string NamDoc { get; set; }
    }
}
