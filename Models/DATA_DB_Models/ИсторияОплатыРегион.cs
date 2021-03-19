using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ИсторияОплатыРегион
    {
        public int Выражение1 { get; set; }
        public DateTime? Дата { get; set; }
        public decimal? СуммаОплаты { get; set; }
        public decimal? СуммаОплатыR { get; set; }
        public string НомерПлатежки { get; set; }
        public int? IdДилера { get; set; }
        public DateTime? ДатаПр { get; set; }
        public decimal? Резерв { get; set; }
        public decimal? РезервR { get; set; }
        public int Регион { get; set; }
        public int НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int RecordId { get; set; }
        public int? KlientReg { get; set; }
    }
}
