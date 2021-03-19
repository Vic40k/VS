using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПоСчетамКонтрольныйВсе
    {
        public int НомерПокупателя { get; set; }
        public int? Накладная { get; set; }
        public byte? ОбоснованиеБлокировки { get; set; }
        public decimal? СуммаR { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int? Фирма { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаСчетаДоСкидки { get; set; }
        public decimal? СуммаЦр { get; set; }
        public string Expr1 { get; set; }
        public string ВыписанСчет { get; set; }
        public int? IdФирмы { get; set; }
        public DateTime? FirstДатаПр { get; set; }
        public byte? FirstВидПлатежа { get; set; }
        public string FirstНомерПлатежки { get; set; }
        public DateTime? Отгружена { get; set; }
        public decimal? СуммаДоставки { get; set; }
        public short? Префикс { get; set; }
        public DateTime? Expr2 { get; set; }
    }
}
