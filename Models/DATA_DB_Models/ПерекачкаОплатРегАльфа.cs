using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПерекачкаОплатРегАльфа
    {
        public string Inn { get; set; }
        public string Поставщик { get; set; }
        public string Счет { get; set; }
        public DateTime? ДатаСо { get; set; }
        public DateTime? ДатаПр { get; set; }
        public string НомерПлатежки { get; set; }
        public decimal? СуммаОплатыR { get; set; }
        public string Назн { get; set; }
        public int? IdКлиента { get; set; }
        public string Контрагент { get; set; }
        public string Расч { get; set; }
        public string КодГорода { get; set; }
        public decimal? СуммаПоВыписке { get; set; }
        public string Код { get; set; }
        public string Фирма { get; set; }
    }
}
