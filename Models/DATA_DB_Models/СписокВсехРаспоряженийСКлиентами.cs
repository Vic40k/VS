using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокВсехРаспоряженийСКлиентами
    {
        public int Распор { get; set; }
        public int? Cчет { get; set; }
        public string Наименование { get; set; }
        public int? ДилерКлиент { get; set; }
        public int? Idfirm { get; set; }
        public int Expr1 { get; set; }
        public int? НомерСчета { get; set; }
        public int Expr2 { get; set; }
        public int Expr3 { get; set; }
        public DateTime? Дата { get; set; }
        public int? Expr4 { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public string Стадия { get; set; }
        public string Водитель { get; set; }
        public int Секретно { get; set; }
    }
}
