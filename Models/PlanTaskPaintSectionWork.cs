using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlanTaskPaintSectionWork
    {
        public int Id { get; set; }
        public int Idtask { get; set; }
        public int? Idplant { get; set; }
        public int Priority { get; set; }
        public string Detail { get; set; }
        public int Quantity { get; set; }
        public decimal? TimeRate { get; set; }
        public string PaintCode { get; set; }
        public string ProductionCode { get; set; }
        public int? Iduser { get; set; }
    }
}
