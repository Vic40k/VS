using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетПеремещенияПромТт
    {
        public string Юрлицо { get; set; }
        public string Поставщик { get; set; }
        public DateTime? Дата { get; set; }
        public string НомерНакл { get; set; }
        public int? Накладная { get; set; }
        public short? Префикс { get; set; }
        public string Наименование { get; set; }
        public decimal? Количество { get; set; }
        public string Артикул { get; set; }
        public decimal? Цена { get; set; }
        public decimal? СуммаБезНалога { get; set; }
        public decimal? Ндс { get; set; }
        public decimal? СуммаСНдс { get; set; }
        public int? Код { get; set; }
        public string НомерГтд { get; set; }
        public string СтранаПроисхождения { get; set; }
        public int Номер { get; set; }
        public int IdСклада { get; set; }
        public int RecordId { get; set; }
        public decimal? Nds { get; set; }
    }
}
