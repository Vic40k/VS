using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходТовараДляАктаСверки
    {
        public int НомерПокупателя { get; set; }
        public int? Накладная { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public double? СуммаR { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int IdДилера { get; set; }
        public byte UsdRu { get; set; }
        public int? IdФирмы { get; set; }
        public int? IdЮрлица { get; set; }
        public short? Префикс { get; set; }
        public int RecordId { get; set; }
        public decimal? План { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
    }
}
