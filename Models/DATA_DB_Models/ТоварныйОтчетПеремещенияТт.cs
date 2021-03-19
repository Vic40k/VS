using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетПеремещенияТт
    {
        public int IdСклада { get; set; }
        public string Наименование { get; set; }
        public int Expr1 { get; set; }
        public string Expr2 { get; set; }
        public int Expr3 { get; set; }
        public string Expr4 { get; set; }
        public int Ном1 { get; set; }
        public DateTime? ДатаПрихода { get; set; }
        public string Артикул { get; set; }
        public string Товар { get; set; }
        public string Модель { get; set; }
        public int? GroupOfGoods { get; set; }
        public string Expr5 { get; set; }
        public decimal Количество { get; set; }
        public double Вес { get; set; }
        public string НомерГтд { get; set; }
        public string СтранаПроисхождения { get; set; }
        public DateTime? Expr6 { get; set; }
        public int RecordId { get; set; }
        public decimal? Nds { get; set; }
    }
}
