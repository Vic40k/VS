﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ГрафикПродажЗаТриГодаРегион
    {
        public int? Год { get; set; }
        public decimal? Сумма { get; set; }
        public int? IdДилера { get; set; }
        public decimal? СуммаОплат { get; set; }
        public int Регион { get; set; }
        public decimal? Доходность { get; set; }
        public decimal? Cc { get; set; }
        public int? UserId { get; set; }
        public decimal? СуммаСентДек { get; set; }
        public int RecordId { get; set; }
    }
}
