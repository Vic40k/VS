using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlanTaskSection
    {
        public int Id { get; set; }
        public int IdtaskType { get; set; }
        public int NumberTask { get; set; }
        public DateTime DateTask { get; set; }
        public byte TurnTask { get; set; }
        public int Idsection { get; set; }
        public int Unit { get; set; }
        public int IdtaskWeld { get; set; }
        public byte Sorting { get; set; }
    }
}
