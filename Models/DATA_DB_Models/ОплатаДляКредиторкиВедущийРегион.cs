using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатаДляКредиторкиВедущийРегион
    {
        public int НомерПокупателя { get; set; }
        public decimal? СуммаОплат { get; set; }
        public decimal? СуммаОплатыРуб { get; set; }
        public DateTime? ДатаПр { get; set; }
        public int RecordId { get; set; }
        public int Регион { get; set; }
        public decimal? Знак { get; set; }
        public decimal? СуммаОплатыРубБезНдс { get; set; }
        public int? Idvo { get; set; }
    }
}
