using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляОплатыОбщийРегион
    {
        public int Выражение1 { get; set; }
        public string Накладная { get; set; }
        public DateTime Дата { get; set; }
        public decimal? Сумма { get; set; }
        public double? СуммаR { get; set; }
        public int Percent { get; set; }
        public int IdДилера { get; set; }
        public int Номер { get; set; }
        public DateTime? Отпущена { get; set; }
        public int Склад { get; set; }
        public bool ВидОплаты { get; set; }
        public decimal? SumСуммаОплаты { get; set; }
        public decimal? SumСуммаОплатыR { get; set; }
        public int Регион { get; set; }
        public string НомерНакл { get; set; }
        public int? Id { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int? Тендер { get; set; }
        public decimal? СкидкаДоп { get; set; }
        public int? KlientSvoj { get; set; }
        public int? KlientRegSvoj { get; set; }
    }
}
