using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПоставщиковПромет
    {
        public short Idпоставщика { get; set; }
        public string Название { get; set; }
        public string ПолноеНаименование { get; set; }
        public string Адрес1 { get; set; }
        public string Адрес2 { get; set; }
        public string Адрес3 { get; set; }
        public string КодИзготовителя { get; set; }
        public bool? Изготовитель { get; set; }
        public string Bux { get; set; }
    }
}
