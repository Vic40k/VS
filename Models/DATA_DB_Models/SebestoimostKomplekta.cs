using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class SebestoimostKomplekta
    {
        public int IdТовара { get; set; }
        public double? Seb { get; set; }
        public double? SebR { get; set; }
        public double? SsrБезНдс { get; set; }
        public double? Цп { get; set; }
        public double? Цена { get; set; }
    }
}
