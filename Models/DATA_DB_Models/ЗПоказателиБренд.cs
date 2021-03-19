using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗПоказателиБренд
    {
        public int Год { get; set; }
        public int Месяц { get; set; }
        public int? Регион { get; set; }
        public decimal? ОплатыДвери { get; set; }
        public decimal? ДоходДвери { get; set; }
        public decimal? ИздержкиДвери { get; set; }
        public decimal? ПланДвери { get; set; }
        public decimal? ФактДвери { get; set; }
        public decimal? КорректировкаИздержекФилиала { get; set; }
    }
}
