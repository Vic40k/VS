using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетРасходРегионыЦепь
    {
        public int IdТовара { get; set; }
        public string Фирма { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public decimal Количество { get; set; }
        public int IdСклада { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int RecordId { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public int IdФирмы { get; set; }
    }
}
