using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетРасходРегионЕвродвери
    {
        public string Покупатель { get; set; }
        public DateTime? Дата { get; set; }
        public int? НомерПорядковый { get; set; }
        public string КодМагазина { get; set; }
        public byte ВнешнийНомер { get; set; }
        public short? Префикс { get; set; }
        public string Накладная { get; set; }
        public string НомерНакл { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public decimal Количество { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public string Примечание { get; set; }
        public int IdСклада { get; set; }
        public int Номер { get; set; }
        public string Inn { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public decimal Expr1 { get; set; }
        public int? GroupOfGoods { get; set; }
        public int Регион { get; set; }
        public int IdФирмы { get; set; }
        public int RecordId { get; set; }
        public decimal? Nds { get; set; }
        public double? IdКаналаСбыта { get; set; }
    }
}
