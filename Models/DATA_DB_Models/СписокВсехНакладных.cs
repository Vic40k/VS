using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокВсехНакладных
    {
        public int Распор { get; set; }
        public int? Cчет { get; set; }
        public string Наименование { get; set; }
        public int? ДилерКлиент { get; set; }
        public int? Idfirm { get; set; }
        public int ВидОплаты { get; set; }
        public int? НомерСчета { get; set; }
        public int UsdRu { get; set; }
        public int IdДилера { get; set; }
        public DateTime? Дата { get; set; }
        public int? Префикс { get; set; }
        public int? Фирма { get; set; }
        public string Год { get; set; }
        public int? НомерПорядковый { get; set; }
    }
}
