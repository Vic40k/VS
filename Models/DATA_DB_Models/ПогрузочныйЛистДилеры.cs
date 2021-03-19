using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПогрузочныйЛистДилеры
    {
        public string Грузоп { get; set; }
        public string Юрлицо { get; set; }
        public int IdДилера { get; set; }
        public int Номер { get; set; }
        public int? НомерСчета { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public string ДоверенностьДата { get; set; }
        public string Expr1 { get; set; }
        public bool Оплачена { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public DateTime ДатаЗаявки { get; set; }
        public string КодЗаказа { get; set; }
        public DateTime? ДатаЗаказа { get; set; }
        public string КодМагазина { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public int? UserId { get; set; }
        public string Товар { get; set; }
        public decimal? Количество { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public string КодТовара { get; set; }
        public double? Вес { get; set; }
        public int? GroupOfGoods { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string Год { get; set; }
        public int? НомерПорядковый { get; set; }
        public int? IdФирмы { get; set; }
        public string Окпо { get; set; }
        public string ОкпоГр { get; set; }
        public string Obi { get; set; }
        public string InnAd { get; set; }
        public string InnUl { get; set; }
        public string Маршрут { get; set; }
        public string ВыставкаДоговор { get; set; }
        public string Password { get; set; }
        public byte UsdRu { get; set; }
        public string Леруа { get; set; }
        public string Pragmatic { get; set; }
        public string Наименование { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string УпаковкаНомер { get; set; }
        public string ПаллетаНомер { get; set; }
        public string КодЗакРасх { get; set; }
        public string Телефон { get; set; }
        public string Фамилия1 { get; set; }
        public string Имя1 { get; set; }
        public string Телефон1 { get; set; }
        public int? ФактМест { get; set; }
        public string Склад { get; set; }
        public int? Категория { get; set; }
        public string УсловияПоставкиType { get; set; }
        public short КоличествоВУпаковке { get; set; }
        public int? КоличествоВЕдинице { get; set; }
        public double? Объем { get; set; }
        public int RecordId { get; set; }
        public string Примечание { get; set; }
        public short? Префикс { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public string КодЗакЗаявка { get; set; }
        public string Expr2 { get; set; }
        public int IdТовара { get; set; }
        public string Адрес { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public decimal? ВремяПогрузки { get; set; }
        public decimal? Nds { get; set; }
        public string НомерНакл { get; set; }
    }
}
