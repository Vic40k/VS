using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходВозвратДляАктаСверкиРегион225
    {
        public int НомерПокупателя { get; set; }
        public decimal? Сумма { get; set; }
        public double? СуммаРуб { get; set; }
        public string Накладная { get; set; }
        public DateTime? ДатаПрихода { get; set; }
        public int RecordId { get; set; }
        public int Регион { get; set; }
        public string НаименованиеОперации { get; set; }
        public decimal Количество { get; set; }
        public int IdДилера { get; set; }
        public int IdФирмы { get; set; }
        public string НомерНакл { get; set; }
        public int IdТовара { get; set; }
        public string Expr2 { get; set; }
        public int? KlientSvoj { get; set; }
        public int? KlientRegSvoj { get; set; }
    }
}
