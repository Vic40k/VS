using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class TestПрогнозSafe
    {
        public int Id { get; set; }
        public int FactoryId { get; set; }
        public int UserId { get; set; }
        public string ArticulTo { get; set; }
        public double? Smonth1 { get; set; }
        public double? Smonth2 { get; set; }
        public double? Smonth3 { get; set; }
        public string ArticulSafe { get; set; }
        public string Name { get; set; }
        public decimal? Kol { get; set; }
    }
}
