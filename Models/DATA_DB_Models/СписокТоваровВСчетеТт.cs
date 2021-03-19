using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоваровВСчетеТт
    {
        public int НомерПокупателя { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public decimal Количество { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? Цена { get; set; }
        public string КодТовара { get; set; }
        public int IdСклада { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public decimal ЦенаПродажи { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public decimal БазоваяЦена { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public DateTime ДатаПредполагаемойПродажи { get; set; }
        public int UserId { get; set; }
        public int RecordId { get; set; }
        public decimal Sebestoimost { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public int? GroupOfGoods { get; set; }
        public double Объем { get; set; }
        public double? Вес { get; set; }
        public decimal? ПроцСкидки { get; set; }
        public int? Исключить { get; set; }
        public decimal? Всего { get; set; }
        public decimal? ВсегоR { get; set; }
        public decimal? ЦенаСоСкидкой { get; set; }
        public decimal? ВозможноеКол { get; set; }
    }
}
