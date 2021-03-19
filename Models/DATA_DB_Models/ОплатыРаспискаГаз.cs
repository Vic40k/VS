using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатыРаспискаГаз
    {
        public int? IdДилера { get; set; }
        public decimal? СуммаОплатыR { get; set; }
        public int НомерСчета { get; set; }
        public DateTime? Дата { get; set; }
        public DateTime? ДатаПр { get; set; }
        public string НомерПлатежки { get; set; }
        public int RecordId { get; set; }
        public decimal? СуммаОплатыRРезерв { get; set; }
        public string Наименование { get; set; }
        public int Менеджер { get; set; }
        public decimal? СуммаОплатыРезерв { get; set; }
        public decimal? СуммаОплаты { get; set; }
        public decimal? КурсЦб { get; set; }
        public int? RecordKreditnoty { get; set; }
        public int? IdРаботничка { get; set; }
        public int? IdВладельца { get; set; }
        public string ИннОтпр { get; set; }
        public int? Expr1 { get; set; }
    }
}
