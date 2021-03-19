using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class АсупУчастки
    {
        public string Section { get; set; }
        public string Nam { get; set; }
        public string ProductionType { get; set; }
        public decimal TimeRatePrice { get; set; }
        public int Unit { get; set; }
    }
}
