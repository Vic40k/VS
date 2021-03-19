using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоваровВСчетеАванс
    {
        public int НомерПокупателя { get; set; }
        public short? Префикс { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public decimal Количество { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public DateTime? Дата { get; set; }
        public string КодТовара { get; set; }
        public decimal? СуммаОплатыR { get; set; }
        public decimal? ЦенаРуб { get; set; }
        public int Выражение1 { get; set; }
        public int Номер { get; set; }
        public int НомерПорядковый { get; set; }
        public int? IdФирмы { get; set; }
        public string Год { get; set; }
    }
}
