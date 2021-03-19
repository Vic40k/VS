﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВсегоНаСкладеТипЗаказ
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public decimal? Pri { get; set; }
        public decimal? Nedogr { get; set; }
        public decimal? Ras { get; set; }
        public int ВМашине { get; set; }
        public int? НомерЗаказа { get; set; }
        public int РегионЗаказа { get; set; }
        public string Наименование { get; set; }
        public decimal? SsrZak { get; set; }
    }
}
