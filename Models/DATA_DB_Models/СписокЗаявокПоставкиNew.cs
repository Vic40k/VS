using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокПоставкиNew
    {
        public int Номер { get; set; }
        public string Наименование { get; set; }
        public DateTime Дата { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public int Поставщик { get; set; }
        public decimal? Сумма { get; set; }
        public string Валюта { get; set; }
    }
}
