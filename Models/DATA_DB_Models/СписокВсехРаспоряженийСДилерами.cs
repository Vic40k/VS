using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокВсехРаспоряженийСДилерами
    {
        public int Распор { get; set; }
        public int? Cчет { get; set; }
        public string Наименование { get; set; }
        public int? ДилерКлиент { get; set; }
        public int? Idfirm { get; set; }
        public bool ВидОплаты { get; set; }
        public int? НомерСчета { get; set; }
        public byte UsdRu { get; set; }
        public int IdДилера { get; set; }
        public DateTime Дата { get; set; }
        public int? Префикс { get; set; }
        public bool Выставка { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public string Стадия { get; set; }
        public string Водитель { get; set; }
    }
}
