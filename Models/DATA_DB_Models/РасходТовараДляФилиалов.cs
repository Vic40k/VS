using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходТовараДляФилиалов
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public byte ДилерКлиент { get; set; }
        public int НомерПокупателя { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public double ЦенаПродажи { get; set; }
        public double ЦенаПродажиR { get; set; }
        public double БазоваяЦена { get; set; }
        public double БазоваяЦенаR { get; set; }
        public float Количество { get; set; }
        public DateTime ДатаПредполагаемойПродажи { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int UserId { get; set; }
        public int RecordId { get; set; }
        public double Sebestoimost { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public string Основание { get; set; }
        public string Накладная { get; set; }
        public double? КоличествоДляОтгрузки { get; set; }
        public string УпаковкаНомер { get; set; }
        public string ПаллетаНомер { get; set; }
        public int? Префикс { get; set; }
        public double? Ssr { get; set; }
    }
}
