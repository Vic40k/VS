using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетСписание111111
    {
        public DateTime? Дата { get; set; }
        public string Expr1 { get; set; }
        public decimal? Количество { get; set; }
        public string Артикул { get; set; }
        public string Акт { get; set; }
        public string Распоряжение { get; set; }
        public string Основание { get; set; }
        public decimal? Сумма { get; set; }
        public decimal Sebestoimost { get; set; }
        public int RecordId { get; set; }
        public int IdТовара { get; set; }
    }
}
