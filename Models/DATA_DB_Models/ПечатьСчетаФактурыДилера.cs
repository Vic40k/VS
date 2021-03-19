using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПечатьСчетаФактурыДилера
    {
        public string Грузоп { get; set; }
        public string Юрлицо { get; set; }
        public int Номер { get; set; }
        public string Примечание { get; set; }
        public bool УсловияПоставки { get; set; }
        public string Склад { get; set; }
        public DateTime Дата { get; set; }
        public int UserId { get; set; }
        public decimal? Объем { get; set; }
        public int? Вес { get; set; }
        public string Inn { get; set; }
        public string Телефоны { get; set; }
        public string Контракт { get; set; }
        public int? Отсрочка { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public short? ТипКонтракта { get; set; }
        public string КодЗаказа { get; set; }
        public DateTime? ДатаЗаказа { get; set; }
        public string КодМагазина { get; set; }
        public int? Id { get; set; }
        public string История { get; set; }
        public int? Expr1 { get; set; }
        public string KppDil { get; set; }
        public string KppUl { get; set; }
        public int? IdЮрлица { get; set; }
        public string Адрес { get; set; }
        public string Пост { get; set; }
        public string Год { get; set; }
        public int? НомерПорядковый { get; set; }
        public int? IdФирмы { get; set; }
        public string НомерНакл { get; set; }
        public string Контакт { get; set; }
        public string Gln { get; set; }
        public DateTime? Отгружена { get; set; }
        public byte UsdRu { get; set; }
        public int? Рс { get; set; }
        public string ИдНомер { get; set; }
    }
}
