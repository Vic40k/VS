using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПоЗаявкамДляОплаты
    {
        public int НомерПокупателя { get; set; }
        public int? Накладная { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public double? СуммаR { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int? Фирма { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаСчетаДоСкидки { get; set; }
        public decimal? СуммаЦр { get; set; }
    }
}
