using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HistSoglUp
    {
        public string UpCod { get; set; }
        public int IdIzgot { get; set; }
        public string GlTech { get; set; }
        public DateTime? DateTech { get; set; }
        public string PrMen { get; set; }
        public DateTime? DateMen { get; set; }
        public DateTime? DateStart { get; set; }
    }
}
