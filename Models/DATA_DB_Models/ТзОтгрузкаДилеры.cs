using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТзОтгрузкаДилеры
    {
        public int? IdКл { get; set; }
        public string Филиал { get; set; }
        public string Дилер { get; set; }
        public string Наименование { get; set; }
        public string Город { get; set; }
        public decimal? СуммаРуб { get; set; }
        public int? UserId { get; set; }
        public int? Рег { get; set; }
        public decimal? СуммаРубПг { get; set; }
    }
}
