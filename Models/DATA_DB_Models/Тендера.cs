using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Тендера
    {
        public int RecordId { get; set; }
        public DateTime? Дата { get; set; }
        public int? Регион { get; set; }
        public int? IdГорода { get; set; }
        public string Заказчик { get; set; }
        public decimal? НачальнаяЦенаКонтракта { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public DateTime? ДатаОкончанияПриемаЗаявок { get; set; }
        public string ТипПродукции { get; set; }
        public string ОписаниеПродукции { get; set; }
        public string СпособЗакупки { get; set; }
        public string ЗаявленоУчастиеПромета { get; set; }
        public string ЗаявленоУчастиеДилераПромета { get; set; }
        public string ПричинаОтказаОтУчастия { get; set; }
        public string ПричинаПоражения { get; set; }
        public string Победитель { get; set; }
        public int? IdГородаПобедителя { get; set; }
        public DateTime? ДатаИсполнения { get; set; }
        public int? КтоВнес { get; set; }
        public string ИннПобедителя { get; set; }
        public decimal? ЦенаКонтракта { get; set; }
        public string ПрометПобедил { get; set; }
        public string СледующийПобедительСЛучшейЦеной { get; set; }
        public int? IdГородаСледующегоПобедителя { get; set; }
        public decimal? ЦенаКонтрактаСледующего { get; set; }
        public string КтоЕщеИзДилеровУчаствовал { get; set; }
        public int? IdДилераТо { get; set; }
        public int? РегионДилера { get; set; }
        public string МестоНахождения { get; set; }
        public string Фио { get; set; }
        public decimal? Себестоимость { get; set; }
        public decimal? ЦенаПродажи { get; set; }
        public int? НомерСчета { get; set; }
        public decimal? Рентабельность { get; set; }
        public string Примечание { get; set; }
        public byte[] Фотокарточки { get; set; }
        public string Статус { get; set; }
        public int? IdСтатуса { get; set; }
        public string БронированиеТендера { get; set; }
        public string ДилерТо { get; set; }
        public int? Ответственный { get; set; }
        public int? СпецТендОтдела { get; set; }
        public string Куратор { get; set; }
        public string Фз { get; set; }
        public string Этп { get; set; }
        public string НомерТендера { get; set; }
        public string ОтКого { get; set; }
        public string Ссылка { get; set; }
        public decimal? ЦенаПобедителя { get; set; }
        public decimal? ОбеспечениеЗаявки { get; set; }
        public decimal? ОбеспечениеКонтракта { get; set; }
        public decimal? ОбеспечениеГо { get; set; }
        public DateTime? ДатаПроведенияТоргов { get; set; }
        public DateTime? ДатаЗаключенияКонтракта { get; set; }
        public string _2Место { get; set; }
        public string АдресРассылки { get; set; }
        public int? Разослать { get; set; }
        public int? РегионСчета { get; set; }
        public decimal? ПроцСнижения { get; set; }
    }
}
