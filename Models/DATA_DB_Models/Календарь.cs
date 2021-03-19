using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Календарь
    {
        public int Код { get; set; }
        public int? Месяц { get; set; }
        public int? Год { get; set; }
        public string Сотировка { get; set; }
    }
}
