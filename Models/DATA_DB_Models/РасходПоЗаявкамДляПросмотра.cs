using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПоЗаявкамДляПросмотра
    {
        public int НомерПокупателя { get; set; }
        public double? СуммаРуб { get; set; }
        public decimal? Сумма { get; set; }
        public int? Накладная { get; set; }
        public decimal? Сс { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public decimal? ВСчете { get; set; }
        public string Основание { get; set; }
        public decimal? Сср { get; set; }
        public double? СуммаСчета { get; set; }
    }
}
