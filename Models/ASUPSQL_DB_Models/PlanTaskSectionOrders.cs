using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlanTaskSectionOrders
    {
        public int Id { get; set; }
        public int Idtask { get; set; }
        public int? IdorderSp { get; set; }
        public int OrderNumberTo { get; set; }
    }
}
