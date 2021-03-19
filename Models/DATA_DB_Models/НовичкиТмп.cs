using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НовичкиТмп
    {
        public int? UserId { get; set; }
        public string Группа { get; set; }
        public int? ОбъемПродажОбщийРубБезНдс { get; set; }
        public int? ОбъемПродаж3ГодаРубБезНдс { get; set; }
        public int? ОбъемПродаж3ГодаШт { get; set; }
        public int? ОбъемПродаж1ГодРубБезНдс { get; set; }
        public int? ОбъемПродаж1ГодШт { get; set; }
        public int? Сортировка { get; set; }
        public string Тип { get; set; }
    }
}
