using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокРекламаций
    {
        public DateTime? ДатаВвода { get; set; }
        public string Наименование { get; set; }
        public DateTime? ДатаИсполнения { get; set; }
        public string ОписаниеДефекта { get; set; }
        public string Контакт { get; set; }
        public string Модель { get; set; }
        public int? НомерСчета { get; set; }
        public int? НомерНакладной { get; set; }
        public int RecordId { get; set; }
        public string Решение { get; set; }
        public string ВидСервиса { get; set; }
        public bool Дилер { get; set; }
        public DateTime? ДатаИспСкладом { get; set; }
        public DateTime? ДатаИспЗмк { get; set; }
        public string КомуПередано { get; set; }
        public string Примечание { get; set; }
        public DateTime? ДатаИсполненияПоПлану { get; set; }
        public string Expr1 { get; set; }
        public int? ТипКлиента { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public int? IdОрганизации { get; set; }
        public string ОтчетЗмк { get; set; }
        public int? Регион { get; set; }
        public DateTime? ДатаПолученоФилиалом { get; set; }
        public DateTime? ДатаЗакрытоФилиалом { get; set; }
        public bool? НеУчтеноЗмк { get; set; }
        public string МодельЗамка { get; set; }
        public string Статус { get; set; }
        public decimal? ФинансовыеПотери { get; set; }
        public int? ОбъединитьСПретензией { get; set; }
        public DateTime? ДатаАкта { get; set; }
        public string РекламацияПризнана { get; set; }
    }
}
