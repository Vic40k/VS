using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКПродажеДилерНовТмп
    {
        public string Наименование { get; set; }
        public string КодТовара { get; set; }
        public int? IdТовара { get; set; }
        public int? IdСклада { get; set; }
        public decimal? ОтрицательноеКолВо { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? Expr1 { get; set; }
        public string СтранаПроисхождения { get; set; }
        public int? GroupOfGoods { get; set; }
        public int? IdПодгруппы { get; set; }
        public string Статус { get; set; }
        public decimal? Свободно { get; set; }
        public decimal? Ндс { get; set; }
        public string Клиент { get; set; }
        public int? НомерЗаказа { get; set; }
        public int? РегионЗаказа { get; set; }
        public short? Deleted { get; set; }
        public decimal? Ssr { get; set; }
        public string Площадка { get; set; }
        public int? Регион { get; set; }
        public int? Userid { get; set; }
    }
}
