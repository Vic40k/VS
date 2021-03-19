using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгрузкаРегионы
    {
        public int IdТовара { get; set; }
        public string Товар { get; set; }
        public decimal SumКоличество { get; set; }
        public decimal? СуммаОтгр { get; set; }
        public int Бц { get; set; }
        public decimal? Seb { get; set; }
        public decimal? Ssr { get; set; }
        public DateTime? ДатаВывоза { get; set; }
    }
}
