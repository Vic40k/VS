using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДилеровРегион
    {
        public int Id { get; set; }
        public string Контракт { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string Inn { get; set; }
        public string Окнх { get; set; }
        public string Окпо { get; set; }
        public string Телефоны { get; set; }
        public string Факс { get; set; }
        public string Руководитель { get; set; }
        public double? МаксимальныйКредит { get; set; }
        public double? СуммаТоваров { get; set; }
        public string История { get; set; }
        public int Менеджер { get; set; }
        public int UserId { get; set; }
        public decimal Скидка { get; set; }
        public short? Отсрочка { get; set; }
        public int? IdКаналаСбыта { get; set; }
        public string Код { get; set; }
        public string Телефон2 { get; set; }
        public short? ТипКонтракта { get; set; }
        public int? IdКатегории { get; set; }
        public int? Idd { get; set; }
        public string Email { get; set; }
        public string Контакт { get; set; }
        public string Кпп { get; set; }
        public short? Посредник { get; set; }
        public string Название { get; set; }
        public string Индекс { get; set; }
        public int? IdГорода { get; set; }
        public string УлицаДом { get; set; }
        public bool Deleted { get; set; }
        public bool ЕстьКаталог { get; set; }
        public bool ЕстьСайт { get; set; }
        public double? Базовая { get; set; }
        public double? ЗаВыставку { get; set; }
        public double? ЗаОбъем { get; set; }
        public double? ЗаЛояльность { get; set; }
        public double? ЗаМаркетотчет { get; set; }
        public double? Штраф { get; set; }
        public double? МаксимальныйКредитR { get; set; }
        public int Регион { get; set; }
        public string Email1 { get; set; }
        public bool? РассылкаEmail { get; set; }
        public bool? РассылкаEmail1 { get; set; }
        public double ЗаОбъем1 { get; set; }
        public double ЗаРейтинг { get; set; }
        public double ЗаЭксклюзив { get; set; }
        public double ЗаОтсрочку { get; set; }
        public double Директорская { get; set; }
        public decimal Скидка2011 { get; set; }
        public bool ЦенаПоДоговору { get; set; }
        public int IdДилОбъединения { get; set; }
        public int ФилиалОтч { get; set; }
        public int? План1 { get; set; }
        public int? План2 { get; set; }
        public int? Планmin { get; set; }
        public decimal? СкидкаПлан1 { get; set; }
        public decimal? СкидкаПлан2 { get; set; }
        public decimal? СкидкаПланmin { get; set; }
        public int ТипДилера { get; set; }
        public int? Место { get; set; }
        public int? Соглашение { get; set; }
        public DateTime? ДатаОткрытияДилера { get; set; }
        public double? ЗаВыставку1 { get; set; }
        public double? ЗаСклад { get; set; }
        public int? СкидкаИзКарточки { get; set; }
        public int? ПланГодБонус1 { get; set; }
        public int? ПланГодБонус2 { get; set; }
        public int? ПланГодБонус3 { get; set; }
        public decimal? СкидкаПланГодБонус1 { get; set; }
        public decimal? СкидкаПланГодБонус2 { get; set; }
        public decimal? СкидкаПланГодБонус3 { get; set; }
        public double? КредитMax { get; set; }
        public int RecDl { get; set; }
        public int? СистемаСкидок { get; set; }
    }
}
