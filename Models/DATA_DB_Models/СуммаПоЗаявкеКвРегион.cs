using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СуммаПоЗаявкеКвРегион
    {
        public int Номер { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаДол { get; set; }
        public string FirstНакладная { get; set; }
        public DateTime? FirstДатаВывоза { get; set; }
        public int Регион { get; set; }
        public int IdГородаПочт { get; set; }
    }
}
