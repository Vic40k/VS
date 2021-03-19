using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОбъемПродажЗаТриГода
    {
        public string Год { get; set; }
        public decimal? ОбъемПродажРуб { get; set; }
        public decimal? ОбъемОплатРуб { get; set; }
        public decimal? ДоходностьРуб { get; set; }
        public string Userid { get; set; }
    }
}
