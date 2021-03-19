﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СуммаПрихода
    {
        public int IdТовара { get; set; }
        public double? SumOfКоличество { get; set; }
        public int IdСклада { get; set; }
        public double? БазоваяЦена { get; set; }
        public double? БазоваяЦенаРуб { get; set; }
    }
}
