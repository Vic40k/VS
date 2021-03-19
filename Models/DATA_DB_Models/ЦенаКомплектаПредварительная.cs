using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЦенаКомплектаПредварительная
    {
        public int IdТовара { get; set; }
        public double? SPriceMin { get; set; }
        public double? SSebestoimost { get; set; }
        public double? SЦенаFob { get; set; }
        public double? SSsr { get; set; }
        public double? SSsrUzmk { get; set; }
        public double? SЦеныFobРуб { get; set; }
        public double? SЦпСосенки { get; set; }
        public double? SЦпТула { get; set; }
    }
}
