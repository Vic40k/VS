using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechToolCatalogue
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? IdpersonResponsible { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateCheckLast { get; set; }
        public DateTime? DateCheckNext { get; set; }
        public int? Idplant { get; set; }
        public int? NumberInventory { get; set; }
        public string ProductionTypes { get; set; }
        public DateTime? DatePlan { get; set; }
        public DateTime? DateFact { get; set; }
    }
}
