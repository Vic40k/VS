using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокФирмРегион
    {
        public int IdФирмы { get; set; }
        public string Фирма { get; set; }
        public string Наименование { get; set; }
        public string АдресЮр { get; set; }
        public string АдресПочт { get; set; }
        public string Телефон { get; set; }
        public string БанкРекв { get; set; }
        public string ВБанке { get; set; }
        public string Бик { get; set; }
        public string Город { get; set; }
        public string Инн { get; set; }
        public string Руководитель { get; set; }
        public string ГлБух { get; set; }
        public int? Учтена { get; set; }
        public string КодРеквизита { get; set; }
        public string Грузоотправитель { get; set; }
        public short? UsdRuВОфисе { get; set; }
        public string Кпп { get; set; }
        public int Регион { get; set; }
        public string Нпс { get; set; }
        public string АдресСклада { get; set; }
        public string ОтпускПроизвел { get; set; }
        public int? КоличествоПерсонала { get; set; }
        public decimal? ОсновныеФонды { get; set; }
        public string ПриказСф { get; set; }
        public string ПриказСф1 { get; set; }
        public string АдресЮрСтарыеРеквизиты { get; set; }
        public string БанкРекв29072014 { get; set; }
        public string ВБанке29072014 { get; set; }
        public string Бик29072014 { get; set; }
        public decimal? ПлощадьОфис { get; set; }
        public decimal? ПлощадьСкладДвери { get; set; }
        public decimal? ПлощадьСкладСим { get; set; }
        public decimal? ЦенаОфис { get; set; }
        public decimal? ЦенаСкладДвери { get; set; }
        public decimal? ЦенаСкладСим { get; set; }
        public decimal? ЦенаНдсОфис { get; set; }
        public decimal? ЦенаНдсСкладДвери { get; set; }
        public decimal? ЦенаНдсСкладСим { get; set; }
        public short? ТеплыйСкладДвери { get; set; }
        public short? ТеплыйСкладСим { get; set; }
        public short? ГрузовыеСтСкладДвери { get; set; }
        public short? ГрузовыеСтСкладСим { get; set; }
        public short? НаличиеПогрСкладДвери { get; set; }
        public short? НаличиеПогрСкладСим { get; set; }
        public short? НаличиеШтабСкладДвери { get; set; }
        public short? НаличиеШтабСкладСим { get; set; }
        public string БанкРеквДвери { get; set; }
        public string БанкРеквМедицина { get; set; }
        public string ОсобыеУсловияДляСчета { get; set; }
        public string ПриказСф2 { get; set; }
        public string БанкРеквНовДвери { get; set; }
        public string Новости { get; set; }
        public string БанкРеквРайфДв { get; set; }
        public string ВБанкеРайфДв { get; set; }
        public string БанкРеквРайфМед { get; set; }
        public string БикРайф { get; set; }
        public string ГрузотпрСос { get; set; }
        public string ГрузотпрСосНакл { get; set; }
        public string ПриказСфСос { get; set; }
        public string ПриказСфСос1 { get; set; }
        public string ПриказСфСос2 { get; set; }
        public string ПоставщикСос { get; set; }
    }
}
