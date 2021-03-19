using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СпецСписокДеталей
    {
        public int IdДетали { get; set; }
        public string Шифр { get; set; }
        public string Наименование { get; set; }
        public decimal? Площадь { get; set; }
        public decimal? Периметр { get; set; }
        public string НомерЧертежа { get; set; }
        public decimal? EanCode { get; set; }
        public int? Idizgot { get; set; }
        public int? Кто { get; set; }
        public int? Когда { get; set; }
        public byte[] Чертеж { get; set; }
        public byte[] ЧертежPdf { get; set; }
        public DateTime? ДатаИзменения { get; set; }
        public int? UserUtvKon { get; set; }
        public int? UtvKon { get; set; }
        public DateTime? ДатаИзмененияEn { get; set; }
        public int? UserUtvEn { get; set; }
        public int? UtvEn { get; set; }
        public DateTime? ДатаИзмененияTech { get; set; }
        public int? UserUtvTech { get; set; }
        public int? UtvTech { get; set; }
        public decimal? Вес { get; set; }
        public int? IdМатериала { get; set; }
        public int? ЧертежИзменен { get; set; }
    }
}
