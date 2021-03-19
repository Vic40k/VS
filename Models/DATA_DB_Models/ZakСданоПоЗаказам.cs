using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ZakСданоПоЗаказам
    {
        public float? Остаток { get; set; }
        public string Наименование { get; set; }
        public string NSub { get; set; }
        public int IdТовара { get; set; }
        public decimal? Сдано { get; set; }
        public DateTime Дата { get; set; }
        public decimal? QuantityProducedDay { get; set; }
        public string Group { get; set; }
        public string Expr1 { get; set; }
    }
}
