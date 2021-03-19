using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОбеспечениеДз
    {
        public DateTime? Дата { get; set; }
        public decimal? ОтгрузкаЗа8Недель { get; set; }
        public string Группа { get; set; }
        public int? Регион { get; set; }
        public decimal? Дз { get; set; }
        public string Отдел { get; set; }
        public decimal? Оплаты12Мес { get; set; }
        public int? GroupOfGoods { get; set; }
    }
}
