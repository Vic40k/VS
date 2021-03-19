using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляДолга
    {
        public int Номер { get; set; }
        public int? Накладная { get; set; }
        public DateTime Дата { get; set; }
        public bool ВидОплаты { get; set; }
        public decimal? SumСуммаОплатыR { get; set; }
        public decimal? ДолгРуб { get; set; }
        public decimal? SumСуммаОплаты { get; set; }
        public decimal? Expr2 { get; set; }
        public int IdДилера { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int Склад { get; set; }
        public bool Expr3 { get; set; }
        public int? Отсрочка { get; set; }
        public int? IdЮрлица { get; set; }
        public bool Оплачена { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int? Фирма { get; set; }
        public decimal? СуммаR { get; set; }
        public decimal? ДолгДол { get; set; }
        public decimal? Сумма { get; set; }
        public byte UsdRu { get; set; }
    }
}
