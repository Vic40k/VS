using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляПросмотраРегион
    {
        public int Номер { get; set; }
        public string Наименование { get; set; }
        public DateTime Дата { get; set; }
        public int Менеджер { get; set; }
        public bool Распоряжение { get; set; }
        public bool Оплачена { get; set; }
        public int Id { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public string Фирма { get; set; }
        public bool Перенесена { get; set; }
        public double? СуммаРуб { get; set; }
        public string НомерТт { get; set; }
        public int Регион { get; set; }
        public decimal? СрокОплаты { get; set; }
        public string КодЗаказа { get; set; }
        public byte УсловияПоставки { get; set; }
        public byte Валюта { get; set; }
        public short? Реклама { get; set; }
        public string Грузополучатель { get; set; }
        public string ГрузополучательНакладная { get; set; }
        public decimal? Премия { get; set; }
        public string Кому { get; set; }
        public string Ответственные { get; set; }
        public string Примечание { get; set; }
        public int IdФирмы { get; set; }
        public int? IdПеревозчика { get; set; }
        public byte UsdRu { get; set; }
        public string ОкпоГрузополучателя { get; set; }
        public DateTime? ДатаЗаказа { get; set; }
        public int IdВодителя { get; set; }
        public int IdПункта { get; set; }
        public int? МаксимальныйКредит { get; set; }
        public decimal Отсрочка { get; set; }
        public bool ВидОплаты { get; set; }
        public int? ДилКл { get; set; }
        public decimal? Курс { get; set; }
        public string НомерНакл { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public byte Подтвержден { get; set; }
        public DateTime? ДатаПодтверждения { get; set; }
        public int СамовывозИзМосквы { get; set; }
        public int? IdЗаказчикаТранспорта { get; set; }
        public int Склад { get; set; }
        public double? Доступ { get; set; }
        public string Основание { get; set; }
        public decimal? СкидкаДоп { get; set; }
        public decimal? СкидкаПлан1 { get; set; }
        public decimal? СкидкаПлан2 { get; set; }
        public decimal? СкидкаПросрочка { get; set; }
        public int? IdАдреса { get; set; }
        public int? Секретно { get; set; }
        public decimal ОтсрочкаПродленная { get; set; }
        public string Expr1 { get; set; }
        public string Юрлицо { get; set; }
        public decimal? СкидкаОтсрочка { get; set; }
        public decimal? СкидкаНал { get; set; }
        public decimal? СкидкаОбъем { get; set; }
        public decimal? Смпр { get; set; }
        public decimal? Скидка { get; set; }
        public decimal? СкидкаСез { get; set; }
        public int? Рс { get; set; }
        public string ГрузополучательНакладная1 { get; set; }
        public string ОснованиеУпд { get; set; }
        public short? Доставка { get; set; }
        public int IdДилера { get; set; }
        public double? Вес { get; set; }
        public double? Объем { get; set; }
        public short? Основная { get; set; }
        public int? TenderId { get; set; }
        public string ПричинаОтсрочки { get; set; }
        public int? KlientReg { get; set; }
        public int? ДоходКому { get; set; }
        public decimal? ДоходСколько { get; set; }
        public int? KlientSvoj { get; set; }
        public int? KlientRegSvoj { get; set; }
        public int? RecDl { get; set; }
    }
}
