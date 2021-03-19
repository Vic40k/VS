using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасчетШтрафаРегион
    {
        public int НомерСчета { get; set; }
        public string НомерНакладной { get; set; }
        public double СуммаДолга { get; set; }
        public DateTime ДатаОтгрузки { get; set; }
        public DateTime ПлановаяДатаОплаты { get; set; }
        public int КоличествоДнейПросрочки { get; set; }
        public double РазмерШтрафа { get; set; }
        public double СуммаШтрафа { get; set; }
        public string Юрлицо { get; set; }
        public string Договор { get; set; }
        public int НомерШтрафа { get; set; }
        public int Регион { get; set; }
    }
}
