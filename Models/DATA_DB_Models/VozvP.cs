using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class VozvP
    {
        public DateTime? ДатаВывоза { get; set; }
        public decimal? СуммаОтгр { get; set; }
        public string Наименование { get; set; }
        public string Основание { get; set; }
        public int? Номер { get; set; }
        public string НомерНакл { get; set; }
        public int? UserId { get; set; }
    }
}
