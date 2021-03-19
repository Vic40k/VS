using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СкидкиДилеров
    {
        public int? IdДилера { get; set; }
        public int IdТовара { get; set; }
        public decimal? СкидкаГруппа { get; set; }
        public decimal? СкидкаПодгруппа { get; set; }
        public double? СкидкаМодель { get; set; }
    }
}
