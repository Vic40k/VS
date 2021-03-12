using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlanTaskPaintSection
    {
        public int Id { get; set; }
        public DateTime DateTask { get; set; }
        public byte TurnTask { get; set; }
        public byte LineNumber { get; set; }
        public decimal? TimeChange { get; set; }
        public int Unit { get; set; }
    }
}
