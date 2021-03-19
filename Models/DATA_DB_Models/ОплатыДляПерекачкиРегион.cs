using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатыДляПерекачкиРегион
    {
        public string НомерПлатежки { get; set; }
        public DateTime? ДатаПр { get; set; }
        public decimal? СуммаПоВыписке { get; set; }
        public int? Рег { get; set; }
        public int? Сч { get; set; }
        public string КодГорода { get; set; }
    }
}
