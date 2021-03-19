using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДебКредТмп
    {
        public string Наим { get; set; }
        public int? Наименование { get; set; }
        public int? Номер { get; set; }
        public string Накл { get; set; }
        public int? Префикс { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public decimal? ЗадолженностьПоОтгрузкеДол { get; set; }
        public decimal? ЗадолженностьПоОтгрузкеРуб { get; set; }
        public decimal? СуммаПоСчету { get; set; }
        public decimal? СуммаПоНакладной { get; set; }
        public decimal? СуммаОплат { get; set; }
        public int IdДилера { get; set; }
        public int Регион { get; set; }
        public int UserId { get; set; }
        public decimal? ЗадолженностьПоОтгрузкеРубБезНдс { get; set; }
        public decimal? СуммаПоСчетуБезНдс { get; set; }
        public decimal? СуммаПоНакладнойБезНдс { get; set; }
        public decimal? КредиторкаДол { get; set; }
        public decimal? КредиторкаРуб { get; set; }
    }
}
