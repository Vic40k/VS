using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЖурналПроектовСертификации
    {
        public int RecordId { get; set; }
        public string НомерСертификата { get; set; }
        public DateTime? ДатаСертификата { get; set; }
        public int? КтоВнес { get; set; }
        public DateTime? ДатаРегистрации { get; set; }
        public string НазваниеПроекта { get; set; }
        public int? IdТипаПроекта { get; set; }
        public DateTime? ДатаИнициации { get; set; }
        public string ДокументаИнициации { get; set; }
        public DateTime? ДатаПереговоровСЛабИСертОрганом { get; set; }
        public string ПланПереговоровСЛабИСертОрганом { get; set; }
        public bool ТребуютсяИспытания { get; set; }
        public string ОбразцыНаИспытания { get; set; }
        public string ВКакойЛабИспытания { get; set; }
        public DateTime? ДатаПриемкиОбразца { get; set; }
        public string РезультатПриемкиОбразца { get; set; }
        public string КтоПринялОбразец { get; set; }
        public DateTime? ДатаОтправкиОбразца { get; set; }
        public string КтоОтправилОбразец { get; set; }
        public DateTime? ДатаИспытаний { get; set; }
        public string РезультатИспытаний { get; set; }
        public byte[] ПриложенныеФайлыИспытаний { get; set; }
        public bool ТребуютсяПовторныеИспытания { get; set; }
        public string ИнвойсОплатыИспытаний { get; set; }
        public decimal? СуммаОплатыИспытаний { get; set; }
        public string ВалютаОплаты { get; set; }
        public DateTime? ДатаОплаты { get; set; }
        public string ОтветственныйЗаРазработкуКдДляИспытаний { get; set; }
        public DateTime? ДатаРазработкиКдДляИспытаний { get; set; }
        public string ОтветственныйЗаРазработкуКдДляСерт { get; set; }
        public DateTime? ДатаРазработкиКдДляСерт { get; set; }
        public DateTime? ДатаОтправкиЧертежейДляСерт { get; set; }
        public byte[] ПриложенныеФайлыЧертежей { get; set; }
        public bool ТребуютсяКорректировкаДокументации { get; set; }
        public DateTime? ДатаПолученияРепортаОбИспытаниях { get; set; }
        public int IdКатегории { get; set; }
    }
}
