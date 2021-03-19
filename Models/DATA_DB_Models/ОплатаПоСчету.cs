using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатаПоСчету
    {
        public int НомерСчета { get; set; }
        public decimal? SumСуммаОплаты { get; set; }
        public decimal? SumСуммаОплатыR { get; set; }
        public DateTime? FirstДатаПр { get; set; }
        public byte? FirstВидПлатежа { get; set; }
        public string FirstНомерПлатежки { get; set; }
    }
}
