using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ЗаказПринят
    {
        public string НомерЗаказа { get; set; }
        public DateTime? ДатаОжидаемая { get; set; }
        public int? Idizgot { get; set; }
        public string Наименование { get; set; }
        public decimal? Kol { get; set; }
        public decimal? Pos { get; set; }
        public string NamZak { get; set; }
        public string Det { get; set; }
    }
}
