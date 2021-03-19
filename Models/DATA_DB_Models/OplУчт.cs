using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class OplУчт
    {
        public DateTime? ДатаПр { get; set; }
        public decimal? СуммаОпл { get; set; }
        public string НомерПлатежки { get; set; }
        public string Наименование { get; set; }
        public int? НомерСчета { get; set; }
        public int? UserId { get; set; }
        public int Rec { get; set; }
    }
}
