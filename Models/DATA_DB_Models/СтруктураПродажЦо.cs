using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СтруктураПродажЦо
    {
        public int? НомерГруппы { get; set; }
        public int Регион { get; set; }
        public string Группа { get; set; }
        public decimal? ОбъемПродажРуб { get; set; }
        public decimal? ДоходностьРуб { get; set; }
        public decimal? Кол { get; set; }
        public decimal? ОбъемПродажПгРуб { get; set; }
        public decimal? ДоходностьПгРуб { get; set; }
        public decimal? КолПг { get; set; }
        public int? Дил { get; set; }
        public string Период { get; set; }
        public decimal? ОбъемПродажРубБезНдс { get; set; }
        public decimal? ОбъемПродажПгРубБезНдс { get; set; }
        public string Участок { get; set; }
        public decimal? ДоходностьРубБезНдс { get; set; }
        public decimal? ДоходностьПгРубБезНдс { get; set; }
    }
}
