using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ProductionSetupCache
    {
        public int IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public int? Brigada { get; set; }
        public int? Method { get; set; }
        public string Source { get; set; }
        public bool? UsePremium { get; set; }
        public int? CuratorZp { get; set; }
        public int? CuratorTo1 { get; set; }
        public bool? UseShiftSplit { get; set; }
        public int? OrgId { get; set; }
        public DateTime TabelCloseDate { get; set; }
    }
}
