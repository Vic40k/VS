using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКодовОкраски
    {
        public string Код { get; set; }
        public string Окраска { get; set; }
        public string КодRal { get; set; }
        public int? Двери { get; set; }
        public string НаименованиеАнглийское { get; set; }
        public decimal? Цена { get; set; }
        public int? АналогПоставки { get; set; }
        public decimal? ЦенаКраски { get; set; }
        public int? IdКонструкции { get; set; }
        public decimal? РасходМ2 { get; set; }
        public string КодСортировки { get; set; }
        public string Кратко { get; set; }
        public bool Болгария { get; set; }
    }
}
