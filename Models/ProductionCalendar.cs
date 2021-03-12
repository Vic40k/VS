using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ProductionCalendar
    {
        public int? IdIzgot { get; set; }
        public int? Smena { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Hours { get; set; }
        public int? Holiday { get; set; }
        public string Comments { get; set; }
    }
}
