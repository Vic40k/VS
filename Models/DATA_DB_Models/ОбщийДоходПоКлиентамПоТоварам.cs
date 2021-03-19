using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОбщийДоходПоКлиентамПоТоварам
    {
        public string Название { get; set; }
        public string Наименование { get; set; }
        public string Товар { get; set; }
        public string Статус { get; set; }
        public string Фамилия { get; set; }
        public decimal? СуммаСНдс { get; set; }
        public decimal? Кол { get; set; }
        public string Группа { get; set; }
        public string Подгруппа { get; set; }
        public string Город { get; set; }
        public int? Регион { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public double? Вс { get; set; }
        public double? Об { get; set; }
        public decimal? Ss { get; set; }
        public string Кат { get; set; }
        public decimal? Сумма { get; set; }
        public string Inn { get; set; }
    }
}
