using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасчетСсПечать
    {
        public string Изделие { get; set; }
        public string СтатьяЗатрат { get; set; }
        public string Наименование { get; set; }
        public string Деталь { get; set; }
        public int IdСтатьиЗатрат { get; set; }
        public decimal? ИтогоРуб { get; set; }
        public decimal? НормаРасхода { get; set; }
        public string ЕдИзм { get; set; }
        public decimal? Цена { get; set; }
        public string Валюта { get; set; }
        public int IdИзделия { get; set; }
        public DateTime ДатаФормирования { get; set; }
        public string Площадка { get; set; }
        public decimal? КурсUsd { get; set; }
        public decimal? КурсEuro { get; set; }
        public decimal? Вес { get; set; }
        public decimal? Количество { get; set; }
        public string Артикул { get; set; }
        public int Категория { get; set; }
        public string Кат { get; set; }
        public string МетодLifo { get; set; }
        public string СНдс { get; set; }
        public decimal? Кдр { get; set; }
        public string ТипРасчета { get; set; }
        public string Кто { get; set; }
        public string АртикулНовый { get; set; }
        public decimal? Ким { get; set; }
        public decimal? Ким2 { get; set; }
        public decimal? Ким3 { get; set; }
        public int IdПлощади { get; set; }
        public string Примечание { get; set; }
        public int? Сортировка { get; set; }
        public decimal? ЦенаСправочник { get; set; }
        public string МетодКосвенных { get; set; }
    }
}
