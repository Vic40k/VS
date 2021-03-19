using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокСчетов
    {
        public int Номер { get; set; }
        public DateTime? Дата { get; set; }
        public int IdКлиента { get; set; }
        public decimal? ТранспортныеРасходы { get; set; }
        public decimal? ВознаграждениеКлиенту { get; set; }
        public string Примечание { get; set; }
        public byte Валюта { get; set; }
        public int УсловияПоставки { get; set; }
        public bool Оплачен { get; set; }
        public bool ВыписаноРаспоряжение { get; set; }
        public bool СчетАнулирован { get; set; }
        public int UserId { get; set; }
        public int ЧейКлиент { get; set; }
        public int? Склад { get; set; }
        public bool Изменен { get; set; }
        public decimal? Курс { get; set; }
        public decimal? Total { get; set; }
        public bool Скидка { get; set; }
        public decimal? ПроцСкидки { get; set; }
        public int? Idkart { get; set; }
        public bool ВыписанаСчетФактура { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public int? IdФирмы { get; set; }
        public decimal? Avans { get; set; }
        public int? ВнешнийНомер { get; set; }
        public DateTime? ВнешняяДата { get; set; }
        public string ПричинаСкидки { get; set; }
        public int? КтоДалСкидку { get; set; }
        public int? IdИсточника { get; set; }
        public int? Накладная { get; set; }
        public DateTime? Отгружена { get; set; }
        public int? IdАдреса { get; set; }
        public int? IdЮрлица { get; set; }
        public DateTime? ДатаЖелаемая { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string Маршрут { get; set; }
        public string Контакт { get; set; }
        public string Телефон { get; set; }
        public bool? Доставка { get; set; }
        public double? Затраты { get; set; }
        public string Водитель { get; set; }
        public DateTime? ВремяНаСклад { get; set; }
        public int? IdСтадии { get; set; }
        public string НомерНакл { get; set; }
        public string Основание { get; set; }
        public int? IdВодителя { get; set; }
        public int? IdПункта { get; set; }
        public int? IdПеревозчика { get; set; }
        public int Секретно { get; set; }
    }
}
