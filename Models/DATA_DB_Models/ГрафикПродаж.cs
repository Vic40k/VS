using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ГрафикПродаж
    {
        public int? НомерМесяца { get; set; }
        public string Месяц { get; set; }
        public decimal? СуммаПродажРуб { get; set; }
        public decimal? СуммаОплатРуб { get; set; }
        public string Userid { get; set; }
    }
}
