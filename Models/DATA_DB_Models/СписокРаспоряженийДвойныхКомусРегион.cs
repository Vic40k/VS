﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокРаспоряженийДвойныхКомусРегион
    {
        public int? Наклад { get; set; }
        public short? Префикс { get; set; }
        public int Cчет { get; set; }
        public string Наименование { get; set; }
        public int? IdСклада { get; set; }
        public string НомерНакл { get; set; }
        public int Регион { get; set; }
        public string КодЗаказа { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
    }
}
