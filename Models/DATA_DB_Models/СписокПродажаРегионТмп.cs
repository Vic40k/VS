using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПродажаРегионТмп
    {
        public string Наименование { get; set; }
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public int? ОтрицательноеКолВо { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? Expr1 { get; set; }
        public string СтранаПроисхождения { get; set; }
        public int? GroupOfGoods { get; set; }
        public string КодТовара { get; set; }
        public decimal? Sebestoimost { get; set; }
        public decimal? Ssr { get; set; }
        public string НомерГтд { get; set; }
        public int? Партия { get; set; }
        public decimal? Цена { get; set; }
        public decimal? Факт { get; set; }
        public string Статус { get; set; }
        public int UserId { get; set; }
    }
}
