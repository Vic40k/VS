using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СпецПозицииСпецификации
    {
        public int IdПозиции { get; set; }
        public int? IdСпецификации { get; set; }
        public int? IdДетали { get; set; }
        public int? IdМатериала { get; set; }
        public int? Idizgot { get; set; }
        public decimal? Количество { get; set; }
        public decimal? КолЧистое { get; set; }
        public string ЕдИзмерения { get; set; }
        public int? IdТовара { get; set; }
        public int? IdМатериалаBg { get; set; }
        public decimal? КоличествоBg { get; set; }
        public decimal? КолЧистоеBg { get; set; }
        public int? IdМатериалаUzmk { get; set; }
        public decimal? КоличествоUzmk { get; set; }
        public decimal? КолЧистоеUzmk { get; set; }
        public string Узел { get; set; }
        public decimal? КолСборок { get; set; }
        public int? ЕдИзм { get; set; }
        public int? Уровень { get; set; }
        public int? НомерПп { get; set; }
        public int? ЕдИзмUzmk { get; set; }
        public int? ЕдИзмBg { get; set; }
        public string Lit { get; set; }
        public string УровеньСорт { get; set; }
        public bool? Изменилась { get; set; }
    }
}
