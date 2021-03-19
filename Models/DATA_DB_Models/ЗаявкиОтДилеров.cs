using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗаявкиОтДилеров
    {
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public int IdДилера { get; set; }
        public string Примечание { get; set; }
        public byte Валюта { get; set; }
        public bool УсловияПоставки { get; set; }
        public int UserId { get; set; }
        public bool ВыписаноРаспоряжение { get; set; }
        public int Склад { get; set; }
        public byte UsdRu { get; set; }
        public bool Оплачена { get; set; }
        public bool Аннулирована { get; set; }
        public DateTime? Срок { get; set; }
        public decimal? Total { get; set; }
        public decimal? Объем { get; set; }
        public int? Вес { get; set; }
        public int? Отсрочка { get; set; }
        public bool ВидОплаты { get; set; }
        public bool ВыписанаСчетФактура { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public int? IdФирмы { get; set; }
        public string КодЗаказа { get; set; }
        public DateTime? ДатаЗаказа { get; set; }
        public int? Накладная { get; set; }
        public DateTime? Отгружена { get; set; }
        public int? IdАдреса { get; set; }
        public int? IdЮрлица { get; set; }
        public int? IdУсловийПоставки { get; set; }
        public int? IdСтадии { get; set; }
        public decimal? КурсВалюты { get; set; }
        public DateTime? ДатаЖелаемая { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string Маршрут { get; set; }
        public string Контакт { get; set; }
        public string Телефон { get; set; }
        public bool? Доставка { get; set; }
        public decimal? Затраты { get; set; }
        public string Водитель { get; set; }
        public string НомерНакл { get; set; }
        public decimal? КолПаллеты { get; set; }
        public int? IdВодителя { get; set; }
        public int? IdПункта { get; set; }
        public int? IdПеревозчика { get; set; }
        public int Филиал { get; set; }
        public int НомерФилиала { get; set; }
        public decimal? СкидкаДоп { get; set; }
        public decimal? СкидкаПлан1 { get; set; }
        public decimal? СкидкаПлан2 { get; set; }
        public int? КтоДопСкидку { get; set; }
        public double? СкидкаПросрочка { get; set; }
        public int? IdЗаказчикаТранспорта { get; set; }
        public decimal? СуммаСчетаДоСкидки { get; set; }
        public double? СкидкаЗаНал { get; set; }
        public int Секретно { get; set; }
        public int? RecordРекламация { get; set; }
        public int ОтсрочкаПродленная { get; set; }
        public decimal? СкидкаОтсрочка { get; set; }
        public decimal? СкидкаНал { get; set; }
        public decimal? СкидкаОбъем { get; set; }
        public decimal? Смпр { get; set; }
        public decimal? СкидкаСезонность { get; set; }
        public decimal? Скидка { get; set; }
        public decimal? СкидкаСез { get; set; }
        public short? Закрыта { get; set; }
        public int? Рс { get; set; }
        public decimal? КурсEur { get; set; }
        public string ПримечаниеНеДляПечати { get; set; }
        public int? ДляКого { get; set; }
        public int? TenderId { get; set; }
        public string ПричинаОтсрочки { get; set; }
    }
}
