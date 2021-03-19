﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВсегоНаСкладеСЦенойТмпЗаказы
    {
        public string Наименование { get; set; }
        public string КодТовара { get; set; }
        public decimal? Expr1 { get; set; }
        public int? IdТовара { get; set; }
        public decimal? БазоваяЦена { get; set; }
        public int? IdСклада { get; set; }
        public decimal? Vputi { get; set; }
        public decimal? Цена { get; set; }
        public decimal? ВСчете { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public string Статус { get; set; }
        public int? Регион { get; set; }
        public int? НомерЗаказа { get; set; }
        public int? РегионЗаказа { get; set; }
        public string Клиент { get; set; }
        public int? Userid { get; set; }
    }
}
