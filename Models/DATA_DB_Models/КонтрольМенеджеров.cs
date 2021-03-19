using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КонтрольМенеджеров
    {
        public int RecordId { get; set; }
        public int? IdДилера { get; set; }
        public int? IdМенеджера { get; set; }
        public decimal? Коэффициент { get; set; }
        public decimal? Смпр { get; set; }
        public decimal? Кредит { get; set; }
        public decimal? Задолженность { get; set; }
        public DateTime? ДатаПоследнейОплаты { get; set; }
        public decimal? Долг { get; set; }
        public string Комментарий { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public decimal? МаксимальныйКредит { get; set; }
        public int? МесячнаяПродажа { get; set; }
        public string ТипДолга { get; set; }
        public DateTime? ДатаОткрытия { get; set; }
        public decimal? ОбъемПродажЮрлица { get; set; }
        public int? Просрочка { get; set; }
        public int Год { get; set; }
        public int Месяц { get; set; }
        public decimal? СмпрЮл { get; set; }
        public decimal? Выставка { get; set; }
        public decimal? ОтгрузкиЗаПериод { get; set; }
        public string Дилер { get; set; }
        public string Фио { get; set; }
        public string Юрлицо { get; set; }
        public string Отдел { get; set; }
        public string Город { get; set; }
        public decimal? Отсрочка { get; set; }
        public decimal? ДолгПродл { get; set; }
        public decimal? ОтсрочкаПродл { get; set; }
        public decimal? ОтсрочкаКарточка { get; set; }
        public int? Мтк { get; set; }
        public string Посредник { get; set; }
        public decimal? Скидка { get; set; }
        public decimal? ЗаОбъем { get; set; }
        public decimal? ЗаРейтинг { get; set; }
        public decimal? ЗаЭксклюзив { get; set; }
        public decimal? ЗаОтсрочку { get; set; }
        public decimal? ЗаВыставку { get; set; }
        public decimal? ЗаСклад { get; set; }
        public decimal? Директорская { get; set; }
        public int? Планmin { get; set; }
        public int? План1 { get; set; }
        public int? План2 { get; set; }
        public decimal? СкидкаПланmin { get; set; }
        public decimal? СкидкаПлан1 { get; set; }
        public decimal? СкидкаПлан2 { get; set; }
    }
}
