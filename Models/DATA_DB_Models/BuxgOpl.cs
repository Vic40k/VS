﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class BuxgOpl
    {
        public int? RecordId { get; set; }
        public string НомерПлатежки { get; set; }
        public DateTime? ДатаПр { get; set; }
        public int? IdДилера { get; set; }
        public string Наименование { get; set; }
        public string Inn { get; set; }
        public double? СуммаОплатыR { get; set; }
        public double? SumСуммаОплатыR { get; set; }
        public int? IdФирмы { get; set; }
        public int? Регион { get; set; }
        public int UserId { get; set; }
    }
}