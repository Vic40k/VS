using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КредТмп
    {
        public string Наименование { get; set; }
        public int? Номер { get; set; }
        public decimal? СуммаОплат { get; set; }
        public decimal? ЗадолженностьПоОтгрузкеДол { get; set; }
        public decimal? ЗадолженностьПоОтгрузкеРуб { get; set; }
        public decimal? ОтгрузкаПоЦенеПродажи { get; set; }
        public int Регион { get; set; }
        public decimal? ЗадолженностьПоОтгрузкеРубБезНдс { get; set; }
        public int? UserId { get; set; }
        public int? IdДилера { get; set; }
    }
}
