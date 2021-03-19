using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Комплектация
    {
        public string ВариантКомплектации { get; set; }
        public string НомерЗаказа { get; set; }
        public string Модель { get; set; }
        public string Цвет { get; set; }
        public double? КоличествоМест { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public string ИзменеияВнес { get; set; }
        public double? IdПоставщика { get; set; }
        public decimal? Цена { get; set; }
        public string ЕдиницаИзмерения { get; set; }
        public int? IdТовара { get; set; }
        public int? IdOrder { get; set; }
        public int IdRecord { get; set; }
        public int? НомерКонтейнера { get; set; }
        public decimal? ЦенаВНакладной { get; set; }
        public string Наименование { get; set; }
        public string Модификация { get; set; }
        public string Артикул { get; set; }
        public string ТехническиеХарактеристики { get; set; }
        public string Назначение { get; set; }
        public string ТребованиеКПоставке { get; set; }
        public double? КоличествоЗаявленное { get; set; }
    }
}
