using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlanDetailsBySections
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public string Section { get; set; }
        public string Detail { get; set; }
        public bool? ItIsDetail { get; set; }
    }
}
