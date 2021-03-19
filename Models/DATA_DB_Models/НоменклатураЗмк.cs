using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НоменклатураЗмк
    {
        public int IdТовара { get; set; }
        public string Категория { get; set; }
        public string Наименование { get; set; }
        public int? IdТипа { get; set; }
        public int? IdКатегории { get; set; }
        public int? IdИзготовителя { get; set; }
        public int? IdМодели { get; set; }
        public int? IdМодификации { get; set; }
        public int? IdОкраски { get; set; }
        public short? КоличествоВУпаковке { get; set; }
        public string Примечание { get; set; }
        public short? ОтрицательноеКолВо { get; set; }
        public double? Объем { get; set; }
        public double? Вес { get; set; }
        public string ЕдиницаИзмерения { get; set; }
        public string Артикул { get; set; }
        public int? GroupOfGoods { get; set; }
        public bool? Разрешение { get; set; }
        public bool? Импорт { get; set; }
        public string Гост { get; set; }
        public int? IdПоставщика { get; set; }
        public int? IdТипаСклада { get; set; }
        public bool? СрокХраненияКонтролировать { get; set; }
        public double? МинимальныйОстатокНаСкладе { get; set; }
        public int? IdУсловияХранения { get; set; }
        public string ТехническиеХарактеристики { get; set; }
    }
}
