using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПретензияПоПродукции
    {
        public int RecordId { get; set; }
        public string НомерАкта { get; set; }
        public DateTime? ДатаАкта { get; set; }
        public DateTime? ДатаНакладной { get; set; }
        public bool Дилер { get; set; }
        public string Контакт { get; set; }
        public int? IdОрганизации { get; set; }
        public string Наименование { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public int? НомерНакладной { get; set; }
        public int? НомерСчета { get; set; }
        public int? IdТовара { get; set; }
        public int? IdДефекта { get; set; }
        public string ОписаниеДефекта { get; set; }
        public int? IdРешения { get; set; }
        public DateTime? ДатаИсполнения { get; set; }
        public bool ОтметкаОбИсполнении { get; set; }
        public decimal? ФинансовыеПотери { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public int? КтоВнес { get; set; }
        public int? Количество { get; set; }
        public decimal? Сумма { get; set; }
        public string ВидСервиса { get; set; }
        public int? IdПретензии { get; set; }
        public DateTime? ДатаИсполненияПоПлану { get; set; }
        public string Оценка { get; set; }
        public int? КодЗатрат { get; set; }
        public DateTime? ДатаИспСкладом { get; set; }
        public DateTime? ДатаИспЗмк { get; set; }
        public string КомуПередано { get; set; }
        public string Примечание { get; set; }
        public int? ТипКлиента { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public int? IdЗамка { get; set; }
        public bool ВыездМастера { get; set; }
        public string КомуПереданоЗмк { get; set; }
        public string ОтчетЗмк { get; set; }
        public string СрокЭксплуатации { get; set; }
        public string СерийныйНомер { get; set; }
        public DateTime? ДатаИзделия { get; set; }
        public string ШтампОтк { get; set; }
        public string Завод { get; set; }
        public DateTime? ДатаПолученоФилиалом { get; set; }
        public DateTime? ДатаЗакрытоФилиалом { get; set; }
        public int? Регион { get; set; }
        public bool? НеУчтеноЗмк { get; set; }
        public string Статус { get; set; }
        public string ФЛЗЧПриняты { get; set; }
        public string КлеймоИсполнителя { get; set; }
        public string СостояниеУпаковки { get; set; }
        public string НеобходимыеЗЧ { get; set; }
        public decimal? ЗатратыСклада { get; set; }
        public decimal? ЗатратыТранспортировки { get; set; }
        public decimal? ЗатратыФилиала { get; set; }
        public decimal? ЗатратыРемучастка { get; set; }
        public int? ГодПродажи { get; set; }
        public string РекламацияПризнана { get; set; }
        public string КорректирующиеДействия { get; set; }
        public string ПринятоеРешение { get; set; }
        public string ПереданныеЗЧ { get; set; }
        public string РешениеФилиала { get; set; }
        public byte[] Фотокарточки { get; set; }
        public string АктРассмотренияРекламации { get; set; }
        public string ПлощадкаРемонта { get; set; }
        public string Фио { get; set; }
        public string Инн { get; set; }
        public string Паспорт { get; set; }
        public string МестоНахождения { get; set; }
        public string МестоРегистрации { get; set; }
        public string ФиоЗам { get; set; }
        public byte[] Фотокарточки1 { get; set; }
        public byte[] Фотокарточки2 { get; set; }
        public byte[] Фотокарточки3 { get; set; }
        public byte[] Фотокарточки4 { get; set; }
        public string МестоХранения { get; set; }
        public string СтатусЮротдела { get; set; }
        public int? ОбъединитьСПретензией { get; set; }
        public string МестоХраненияДоговора { get; set; }
        public string ФиоХраненияДоговора { get; set; }
        public int? IdПодкодДефекта { get; set; }
        public string СкладОтгрузки { get; set; }
        public decimal? ЗатратыНаЗапчасти { get; set; }
    }
}
