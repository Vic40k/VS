using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКонструкций
    {
        public string IdКонструкции { get; set; }
        public string IdКатегории { get; set; }
        public string IdТипа { get; set; }
        public string Конструкция { get; set; }
        public string IdПолотна { get; set; }
        public int? IdЗамка { get; set; }
        public decimal? ЦенаЗамка { get; set; }
        public int? IdЗамкаДоп { get; set; }
        public decimal? ЦенаЗамкаДоп { get; set; }
        public string Короб { get; set; }
        public decimal? Цена { get; set; }
        public int? КолЗамков { get; set; }
        public int? IdНаполнителя { get; set; }
        public string КоробТолщина { get; set; }
        public int? КолКонтуров { get; set; }
        public string Петли { get; set; }
        public string ТольщинаПолотна { get; set; }
        public int? IdКласса { get; set; }
    }
}
