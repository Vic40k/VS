using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгрузкаКонтролируемыхПоДилерам
    {
        public string Наименование { get; set; }
        public string Товар { get; set; }
        public string Склад { get; set; }
        public string Выражение3 { get; set; }
        public decimal SumКоличествоДляОтгрузки1 { get; set; }
        public decimal? Ssr { get; set; }
        public decimal? СуммаОтгр { get; set; }
        public short? Посредник { get; set; }
        public string Статус { get; set; }
        public string Название { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public string Под { get; set; }
        public string Фамилия { get; set; }
    }
}
