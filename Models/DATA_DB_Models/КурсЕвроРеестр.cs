﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КурсЕвроРеестр
    {
        public DateTime Дата { get; set; }
        public int? UserId { get; set; }
        public decimal Курс { get; set; }
        public decimal? КурсоваяРазница { get; set; }
        public decimal? КурсEuro { get; set; }
    }
}
