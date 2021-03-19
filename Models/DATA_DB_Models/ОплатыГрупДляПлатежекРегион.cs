using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатыГрупДляПлатежекРегион
    {
        public int? Регион { get; set; }
        public string НомерПлатежки { get; set; }
        public byte? ВидОплаты { get; set; }
        public DateTime? Дата { get; set; }
        public DateTime? ДатаПр { get; set; }
        public DateTime? Время { get; set; }
        public int? UserId { get; set; }
        public byte? ВидПлатежа { get; set; }
        public decimal? СуммаПоВыписке { get; set; }
        public int? IdФирмы { get; set; }
    }
}
