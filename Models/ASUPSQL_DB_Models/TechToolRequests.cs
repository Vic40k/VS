using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechToolRequests
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ProductionTypes { get; set; }
        public byte ItemsQuantity { get; set; }
        public byte? CheckPeriod { get; set; }
        public DateTime? DatePlanCompletion { get; set; }
        public int? Constructor { get; set; }
        public DateTime? DatePlan { get; set; }
        public DateTime? DateRequest { get; set; }
    }
}
