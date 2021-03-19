using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетПеремещенияПромет
    {
        public int IdСклада { get; set; }
        public int Expr1 { get; set; }
        public string КодЗаказа { get; set; }
        public int? Накладная { get; set; }
        public short? Префикс { get; set; }
        public DateTime? Дата { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public short IdGroupOfGoods { get; set; }
        public string Expr2 { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
        public double Вес { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public decimal? Выражение6 { get; set; }
        public int RecordId { get; set; }
        public decimal? Nds { get; set; }
    }
}
