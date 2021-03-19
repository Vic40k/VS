using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварВЗаявке
    {
        public int НомерПокупателя { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public float Количество { get; set; }
        public double ЦенаПродажи { get; set; }
        public double ЦенаПродажиR { get; set; }
        public double? Объем { get; set; }
        public double? Вес { get; set; }
        public int IdСклада { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public double БазоваяЦена { get; set; }
        public double БазоваяЦенаR { get; set; }
        public string КодТовара { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public DateTime ДатаПредполагаемойПродажи { get; set; }
        public int? Накладная { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public double Sebestoimost { get; set; }
        public int? GroupOfGoods { get; set; }
        public double? КоличествоДляОтгрузки { get; set; }
        public string ПаллетаНомер { get; set; }
        public double? ВесБрутто { get; set; }
    }
}
