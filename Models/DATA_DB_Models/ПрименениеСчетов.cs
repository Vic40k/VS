﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПрименениеСчетов
    {
        public int IdДилера { get; set; }
        public decimal? СуммаОплатыR { get; set; }
        public int? НомерСчета { get; set; }
        public DateTime? Дата { get; set; }
        public DateTime? ДатаПр { get; set; }
        public string НомерПлатежки { get; set; }
        public int RecordId { get; set; }
        public decimal? СуммаОплатыRРезерв { get; set; }
        public string Наименование { get; set; }
        public decimal? СуммаОплатыРезерв { get; set; }
        public decimal? СуммаОплаты { get; set; }
        public decimal Курс { get; set; }
        public decimal? КурсЦб { get; set; }
        public decimal? СуммаПоВыписке { get; set; }
        public int Регион { get; set; }
        public int? UserId { get; set; }
        public string ИннОтпр { get; set; }
        public int? IdФирмы { get; set; }
        public int? KlientReg { get; set; }
        public int RecKl { get; set; }
    }
}
