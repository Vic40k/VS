using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НоменклатураСИсключить
    {
        public int? Исключить { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public string КодТовара { get; set; }
        public double Объем { get; set; }
        public double? Вес { get; set; }
        public string Артикул { get; set; }
        public int? GroupOfGoods { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public int? ТипГруппы { get; set; }
        public int IdПодгруппы { get; set; }
        public short КоличествоВУпаковке { get; set; }
        public int? КоличествоВЕдинице { get; set; }
        public double? ВесБрутто { get; set; }
        public string КодСтраны { get; set; }
        public bool? Тула { get; set; }
        public bool? Сосенки { get; set; }
        public string Статус { get; set; }
        public string Основной { get; set; }
        public int? Участок { get; set; }
    }
}
