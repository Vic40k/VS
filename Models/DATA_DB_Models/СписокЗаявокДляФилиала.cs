using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляФилиала
    {
        public int Номер { get; set; }
        public int НомерЗаявки { get; set; }
        public string Наименование { get; set; }
        public DateTime Дата { get; set; }
        public int Склад { get; set; }
        public bool Распоряжение { get; set; }
        public bool Оплачена { get; set; }
        public int IdСклада { get; set; }
        public string ДатаПереноса { get; set; }
        public string Перенести { get; set; }
        public int? Наклад { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public int? Накладная { get; set; }
        public DateTime? Отгружена { get; set; }
        public bool УсловияПоставки { get; set; }
        public string Откуда { get; set; }
        public byte ТипСклада { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string Маршрут { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Год { get; set; }
    }
}
