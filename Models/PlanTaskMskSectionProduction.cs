using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlanTaskMskSectionProduction
    {
        public int Id { get; set; }
        public string NameProductionSet { get; set; }
        public DateTime DateCreation { get; set; }
        public int Unit { get; set; }
    }
}
