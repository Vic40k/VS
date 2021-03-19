using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДокументов
    {
        public int IdДилера { get; set; }
        public bool? Сверка1999 { get; set; }
        public bool? Устав { get; set; }
        public bool? СвидетельствоОРегистрации { get; set; }
        public bool? Паспорт { get; set; }
        public bool? ПечатьИПодписи { get; set; }
        public bool? Договор2000 { get; set; }
        public bool? Сверка2000 { get; set; }
        public bool? Анкета { get; set; }
        public string Прочие { get; set; }
        public short? ОтчетныйПериод { get; set; }
        public DateTime? ДатаПослОтчета { get; set; }
        public bool? Договор2001 { get; set; }
        public bool? Сверка2001 { get; set; }
        public bool? Договор2002 { get; set; }
        public bool? Сверка2002 { get; set; }
        public DateTime? ДатаОткрытияДилера { get; set; }
    }
}
