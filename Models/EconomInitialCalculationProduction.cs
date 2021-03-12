using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EconomInitialCalculationProduction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? PaintPrice { get; set; }
        public decimal? PaintedSpace { get; set; }
        public int? PaintExpense { get; set; }
        public decimal? WrapsPrice { get; set; }
        public decimal? LabourCoefficient { get; set; }
        public string Note { get; set; }
        public decimal? PaintPrice2 { get; set; }
        public decimal? PaintedSpace2 { get; set; }
        public int? PaintExpense2 { get; set; }
    }
}
