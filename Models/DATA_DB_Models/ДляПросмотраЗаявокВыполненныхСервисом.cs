using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДляПросмотраЗаявокВыполненныхСервисом
    {
        public int Номер { get; set; }
        public string Название { get; set; }
        public DateTime Дата { get; set; }
        public bool Распоряжение { get; set; }
        public int Склад { get; set; }
        public int Менеджер { get; set; }
        public int? Накладная { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string Маршрут { get; set; }
        public string Контакт { get; set; }
        public string Телефон { get; set; }
        public string Причина { get; set; }
        public decimal? Затраты { get; set; }
        public string Водитель { get; set; }
        public string Фамилия { get; set; }
        public string Стадия { get; set; }
        public int? IdСтадии { get; set; }
        public string КодЗаказа { get; set; }
        public int IdДилера { get; set; }
        public DateTime? Отгружена { get; set; }
        public int? Год { get; set; }
        public int? НомерПорядковый { get; set; }
        public int Филиал { get; set; }
        public int? Префикс { get; set; }
    }
}
