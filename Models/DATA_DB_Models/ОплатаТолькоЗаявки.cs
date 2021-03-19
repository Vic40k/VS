using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатаТолькоЗаявки
    {
        public string Expr1 { get; set; }
        public byte? ВидОплаты { get; set; }
        public int? НомерСчета { get; set; }
        public DateTime? ДатаПр { get; set; }
        public decimal? СуммаОплаты { get; set; }
        public decimal? СуммаОплатыR { get; set; }
        public DateTime? Дата { get; set; }
        public int? UserId { get; set; }
        public DateTime? Время { get; set; }
        public byte? ВидПлатежа { get; set; }
        public decimal? СуммаОплатыРезерв { get; set; }
        public decimal? СуммаОплатыRРезерв { get; set; }
        public int RecordId { get; set; }
        public int? IdФирмы { get; set; }
        public int? IdКлиента { get; set; }
        public decimal? СуммаОплатыEuro { get; set; }
        public int? IdЮрлица { get; set; }
        public int? RecordKreditnoty { get; set; }
        public string ИннОтпр { get; set; }
    }
}
