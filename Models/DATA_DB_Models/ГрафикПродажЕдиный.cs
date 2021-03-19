﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ГрафикПродажЕдиный
    {
        public int? Год { get; set; }
        public int? Месяц { get; set; }
        public decimal? Сумма { get; set; }
        public int? IdДилера { get; set; }
        public decimal? СуммаОплат { get; set; }
    }
}
