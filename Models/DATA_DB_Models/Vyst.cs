using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Vyst
    {
        public DateTime? ДатаВывоза { get; set; }
        public int? Номер { get; set; }
        public decimal? СуммаОтгр { get; set; }
        public string Наименование { get; set; }
        public int? Накладная { get; set; }
        public string Накладная1 { get; set; }
        public bool? Нал { get; set; }
        public string КодМагазина { get; set; }
        public string КодЗаказа { get; set; }
        public DateTime? ДатаЗаказа { get; set; }
        public decimal? СуммаЗаказа { get; set; }
        public int? UserId { get; set; }
    }
}
