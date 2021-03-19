using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПечатьСчетаФактурыДилерыКор
    {
        public string Юрлицо { get; set; }
        public int Номер { get; set; }
        public string Примечание { get; set; }
        public bool УсловияПоставки { get; set; }
        public string Склад { get; set; }
        public DateTime Дата { get; set; }
        public int UserId { get; set; }
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
        public decimal? Количество { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public int? GroupOfGoods { get; set; }
        public string Наименование { get; set; }
        public int RecordId { get; set; }
        public string НомерНакл { get; set; }
        public short? Префикс { get; set; }
        public int IdДилера { get; set; }
        public double? Ве { get; set; }
        public decimal? Ндс { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public byte UsdRu { get; set; }
        public string Контакт { get; set; }
        public string SlovaNds { get; set; }
        public string КодГорода { get; set; }
        public int НомерРасп { get; set; }
        public string ВыставкаДоговор { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public string КомуОтпустить { get; set; }
        public string Кто { get; set; }
        public string Артикул { get; set; }
        public byte? ТипСклада { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public string Перевозчик { get; set; }
        public string Ean { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public int? Рс { get; set; }
        public decimal? КолКор { get; set; }
        public string ИдНомер { get; set; }
        public DateTime? ДатаПрихода { get; set; }
    }
}
