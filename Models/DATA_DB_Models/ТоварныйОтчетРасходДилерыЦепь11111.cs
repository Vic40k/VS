using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетРасходДилерыЦепь11111
    {
        public int IdТовара { get; set; }
        public string Фирма { get; set; }
        public string Товар { get; set; }
        public decimal? Количество { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
        public int IdСклада { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int RecordId { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public string НомерНакл { get; set; }
        public int? GroupOfGoods { get; set; }
        public string Группа { get; set; }
        public double? Вес { get; set; }
        public string Модель { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public decimal? Nds { get; set; }
    }
}
