using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Сотрудники
    {
        public string Фирма { get; set; }
        public string Фио { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Должность { get; set; }
        public int? Доступ { get; set; }
        public int ЛичныйНомер { get; set; }
        public int? Группа { get; set; }
        public decimal БазоваяСтавка { get; set; }
        public decimal? СтавкаВРублях { get; set; }
        public DateTime? ДатаВнесенияИзменений { get; set; }
        public int? КтоВнес { get; set; }
        public int? Статус { get; set; }
        public int? ПремияПроц { get; set; }
        public string Примечание { get; set; }
        public string АнглийскоеИмя { get; set; }
        public string НомерКредитнойКарточки { get; set; }
        public string МетодОплаты { get; set; }
        public int? СейфыПроц { get; set; }
        public int? IdСтатьиСейф { get; set; }
        public int? ЗаводПроц { get; set; }
        public int? IdСтатьиЗавод { get; set; }
        public int? ТпоПроц { get; set; }
        public int? IdСтатьиTpo { get; set; }
        public int? АдминПроц { get; set; }
        public int? IdСтатьиAdmin { get; set; }
        public int? DibПроц { get; set; }
        public int? IdСтатьиDib { get; set; }
        public int? OaeПроц { get; set; }
        public int? IdСтатьиOae { get; set; }
        public int? УзмкПроц { get; set; }
        public int? IdСтатьиУзмк { get; set; }
        public string НомерСерии { get; set; }
        public string НомерПаспорта { get; set; }
        public int? БаллКвалификации { get; set; }
        public int? БаллНужности { get; set; }
        public bool? АвтоматическиПересчитать { get; set; }
        public string СтарыйНомер { get; set; }
        public string НомерParex { get; set; }
        public string ФиоParex { get; set; }
        public string НомерКрыловский { get; set; }
        public string ФиоКрыловский { get; set; }
        public int? ВалютаЗарплаты { get; set; }
        public int? IdПроходная { get; set; }
        public string НомерМаст { get; set; }
        public int? Отдел { get; set; }
        public string География { get; set; }
        public int? Hid { get; set; }
        public string Фирма1с { get; set; }
        public decimal? Ставка1с { get; set; }
        public int? IdФирмы { get; set; }
        public int НеРезидент { get; set; }
        public int? ДвериПроц { get; set; }
        public int? IdСтатьиДвери { get; set; }
        public string ДолжностьУправленческая { get; set; }
        public int? КодБдр { get; set; }
        public int? МоПроц { get; set; }
        public int? IdСтатьиМо { get; set; }
    }
}
