using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДоходПоКлиентамРегионКолсч
    {
        public string Наименование { get; set; }
        public string Название { get; set; }
        public DateTime ДатаПр { get; set; }
        public int? Регион { get; set; }
        public int КолWeb { get; set; }
        public int КолВсе { get; set; }
    }
}
