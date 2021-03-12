using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ProductionSetup
    {
        public int IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public decimal ValueMin { get; set; }
        public decimal ValueMax { get; set; }
        public decimal BonusMin { get; set; }
        public decimal BonusMax { get; set; }
        public decimal Salary { get; set; }
        public bool IsProduction { get; set; }
        public string Brigades { get; set; }
        public string Compound { get; set; }
        public int Method { get; set; }
        public bool? UsePremium { get; set; }
        public int? CuratorZp { get; set; }
        public int? CuratorTo1 { get; set; }
        public bool UseShiftSplit { get; set; }
        public int? OrgId { get; set; }
        public double SpecialOrdersKoeff { get; set; }
        public string Operations { get; set; }
        public bool OneInitPerShift { get; set; }
        public bool NoRestrictTabel { get; set; }
        public DateTime TabelCloseDate { get; set; }
    }
}
