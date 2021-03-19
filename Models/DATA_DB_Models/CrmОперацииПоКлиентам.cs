using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class CrmОперацииПоКлиентам
    {
        public string Менеджер { get; set; }
        public int? IdЮрлица { get; set; }
        public string Наименование { get; set; }
        public string Expr1 { get; set; }
        public int? КолВоСчетов { get; set; }
        public string Адрес { get; set; }
        public string Руководитель { get; set; }
        public string Телефоны { get; set; }
        public bool? Доставка { get; set; }
        public int? IdАдреса { get; set; }
        public string Expr2 { get; set; }
        public string Expr3 { get; set; }
        public int Номер { get; set; }
        public string Накладная { get; set; }
        public DateTime? Дата { get; set; }
        public string Expr4 { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int RecordId { get; set; }
        public string ТелефоныДляСервиса { get; set; }
        public string РуководительДляСервиса { get; set; }
    }
}
