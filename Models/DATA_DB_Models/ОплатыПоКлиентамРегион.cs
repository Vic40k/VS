using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатыПоКлиентамРегион
    {
        public int IdДилера { get; set; }
        public int IdФирмы { get; set; }
        public string НомерПлатежки { get; set; }
        public byte? ВидОплаты { get; set; }
        public int? НомерСчета { get; set; }
        public decimal? СуммаОплаты { get; set; }
        public decimal? СуммаОплатыR { get; set; }
        public DateTime? Дата { get; set; }
        public int? UserId { get; set; }
        public DateTime? ДатаПр { get; set; }
        public DateTime? Время { get; set; }
        public byte? ВидПлатежа { get; set; }
        public decimal? СуммаОплатыРезерв { get; set; }
        public decimal? СуммаОплатыRРезерв { get; set; }
        public int RecordId { get; set; }
        public decimal? СуммаПоВыписке { get; set; }
        public bool Перенесена { get; set; }
        public int? Фирма { get; set; }
        public int Регион { get; set; }
        public byte UsdRu { get; set; }
        public int? KlientReg { get; set; }
    }
}
