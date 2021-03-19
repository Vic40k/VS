using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РекламацииПоДверям
    {
        public int НомерРекл { get; set; }
        public DateTime? ДатаАкта { get; set; }
        public string Наименование { get; set; }
        public string Expr1 { get; set; }
        public string ОписаниеДефекта { get; set; }
        public string Артикул { get; set; }
        public int? Количество { get; set; }
        public decimal? Выражение1 { get; set; }
        public decimal? Выражение2 { get; set; }
        public int? IdДефекта { get; set; }
        public int? Регион { get; set; }
        public string Завод { get; set; }
    }
}
