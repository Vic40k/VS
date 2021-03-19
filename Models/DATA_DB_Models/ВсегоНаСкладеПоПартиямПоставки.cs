using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВсегоНаСкладеПоПартиямПоставки
    {
        public string Наименование { get; set; }
        public string КодТовара { get; set; }
        public double? Expr1 { get; set; }
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public int Партия { get; set; }
        public int? GroupOfGoods { get; set; }
        public string Артикул { get; set; }
        public double? Seb { get; set; }
        public double? SebR { get; set; }
        public string НомерГтд1 { get; set; }
        public string Валюта { get; set; }
        public string ЕдИзм { get; set; }
        public int? Поставщик { get; set; }
    }
}
