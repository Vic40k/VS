using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДокументовЮрлиц
    {
        public int IdЮрлица { get; set; }
        public bool? Сверка1999 { get; set; }
        public bool? Устав { get; set; }
        public bool? СвидетельствоОРегистрации { get; set; }
        public bool? Паспорт { get; set; }
        public bool? ПечатьИПодписи { get; set; }
        public bool? Договор2000 { get; set; }
        public bool? Сверка2000 { get; set; }
        public bool? Анкета { get; set; }
        public string Прочие { get; set; }
        public bool? Договор2001 { get; set; }
        public bool? Сверка2001 { get; set; }
        public bool? Договор2005 { get; set; }
        public bool? Сверка2004 { get; set; }
        public bool? Евросейф { get; set; }
        public bool? Нал { get; set; }
        public string Договор { get; set; }
        public bool? Действующий { get; set; }
        public bool? Выставка { get; set; }
    }
}
