using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class CrmОперацииПоДилерам
    {
        public string Менеджер { get; set; }
        public string Название { get; set; }
        public string Expr1 { get; set; }
        public string Руководитель { get; set; }
        public string Телефоны { get; set; }
        public bool? Доставка { get; set; }
        public int Номер { get; set; }
        public string Накладная { get; set; }
        public DateTime Дата { get; set; }
        public string Expr4 { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int RecordId { get; set; }
        public string Контакт { get; set; }
        public string Адрес { get; set; }
        public string Грузополучатель { get; set; }
        public string Телефон2 { get; set; }
        public string ДилКонтакт { get; set; }
        public string ЮлКонтакт { get; set; }
        public string ТелефоныДляСервиса { get; set; }
        public string РуководительДляСервиса { get; set; }
        public string Код { get; set; }
    }
}
