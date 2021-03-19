using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ZakPlanArt
    {
        public int IdIzgot { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Articul { get; set; }
        public string DopCod { get; set; }
        public int? KolZak { get; set; }
        public string Bai { get; set; }
        public DateTime? DateIzm { get; set; }
        public int? Flag { get; set; }
    }
}
