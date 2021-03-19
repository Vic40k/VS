using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДанныеДляПоставокТула
    {
        public int IdТовара { get; set; }
        public decimal СуммаCc { get; set; }
        public decimal Количество { get; set; }
        public decimal Рц { get; set; }
        public decimal Cc { get; set; }
        public int IdСубсчета { get; set; }
        public short Месяц { get; set; }
        public short Год { get; set; }
        public int RecordId { get; set; }
        public decimal СуммаРц { get; set; }
        public int UserId { get; set; }
        public DateTime? Дата { get; set; }
        public decimal? SumБронь { get; set; }
        public decimal? ПланНаДень { get; set; }
        public string КодТовара { get; set; }
        public string Наименование { get; set; }
    }
}
