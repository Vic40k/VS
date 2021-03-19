using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PriTmp
    {
        public int? IdСклада { get; set; }
        public int? IdТовара { get; set; }
        public double? SumOfКоличество { get; set; }
        public int? Регион { get; set; }
        public int? Userid { get; set; }
        public string Клиент { get; set; }
        public int НомерЗаказа { get; set; }
        public int РегионЗаказа { get; set; }
        public decimal? SsrZakaza { get; set; }
        public double? Факт { get; set; }
        public double? ВПути { get; set; }
        public double? Оплачено { get; set; }
        public double? Счет { get; set; }
        public double? Распоряжение { get; set; }
        public double? Недоплачено { get; set; }
        public double? Недогрузы { get; set; }
        public double? Разрешение { get; set; }
        public double? Накл { get; set; }
    }
}
