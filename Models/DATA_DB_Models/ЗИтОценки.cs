using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗИтОценки
    {
        public int Hid { get; set; }
        public int Год { get; set; }
        public int Месяц { get; set; }
        public int? RecOценка { get; set; }
        public string Ответственный { get; set; }
        public string Фио { get; set; }
        public string КМво1 { get; set; }
        public string Оценка1 { get; set; }
        public decimal? Вес1 { get; set; }
        public string КМво2 { get; set; }
        public string Оценка2 { get; set; }
        public decimal? Вес2 { get; set; }
        public string КМво3 { get; set; }
        public string Оценка3 { get; set; }
        public decimal? Вес3 { get; set; }
        public string КМво4 { get; set; }
        public string Оценка4 { get; set; }
        public decimal? Вес4 { get; set; }
        public string КМво5 { get; set; }
        public string Оценка5 { get; set; }
        public decimal? Вес5 { get; set; }
        public string КМво6 { get; set; }
        public string Оценка6 { get; set; }
        public decimal? Вес6 { get; set; }
        public string КМво7 { get; set; }
        public string Оценка7 { get; set; }
        public decimal? Вес7 { get; set; }
        public string Комментарий { get; set; }
    }
}
