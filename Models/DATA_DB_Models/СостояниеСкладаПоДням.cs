﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СостояниеСкладаПоДням
    {
        public int? IdГруппы { get; set; }
        public int? Кол { get; set; }
        public int? СуммаСсРуб { get; set; }
        public DateTime? Дата { get; set; }
        public int? Регион { get; set; }
    }
}
