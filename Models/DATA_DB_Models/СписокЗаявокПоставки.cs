using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокПоставки
    {
        public string Номер { get; set; }
        public string Наименование { get; set; }
        public DateTime? Дата { get; set; }
        public DateTime? ДатаФактаПрихода { get; set; }
        public int? Поставщик { get; set; }
        public double? Сумма { get; set; }
        public string Валюта { get; set; }
        public int? Record { get; set; }
        public DateTime? ДатаОплаты { get; set; }
    }
}
