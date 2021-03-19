using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЮрлицДилеров
    {
        public int IdЮрлица { get; set; }
        public int IdДилера { get; set; }
        public string Наименование { get; set; }
        public string Адрес { get; set; }
        public string Контакт { get; set; }
        public string Инн { get; set; }
        public string Кпп { get; set; }
        public string Руководитель { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string Контракт { get; set; }
        public short? ТипКонтракта { get; set; }
        public short? ОтчетныйПериод { get; set; }
        public DateTime? ДатаПослОтчета { get; set; }
        public int Отсрочка { get; set; }
        public bool? Deleted { get; set; }
        public string Окпо { get; set; }
        public byte[] Подпись { get; set; }
        public bool Выставка { get; set; }
        public string ВыставкаДоговор { get; set; }
        public decimal? ДопскидкаЗаНал { get; set; }
        public short? СНдс { get; set; }
        public int? IdИсточника { get; set; }
        public string ИдНомер { get; set; }
        public string ПокупательДляСфЦо { get; set; }
        public string АдресДляСфЦо { get; set; }
    }
}
