using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварСклад
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public string КодТовара { get; set; }
        public int? GroupOfGoods { get; set; }
        public int IdПодгруппы { get; set; }
        public string Expr1 { get; set; }
        public byte ТипСклада { get; set; }
        public string Артикул { get; set; }
        public decimal СсБезНдс { get; set; }
        public decimal Ssr { get; set; }
        public int Sebestoimost { get; set; }
        public decimal PriceMin { get; set; }
        public decimal Цп { get; set; }
    }
}
