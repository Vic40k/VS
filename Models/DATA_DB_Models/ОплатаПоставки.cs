using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатаПоставки
    {
        public DateTime ДатаОплаты { get; set; }
        public string НомерЗаказа { get; set; }
        public decimal Сумма { get; set; }
        public decimal? СуммаДоллары { get; set; }
        public string Оплатил { get; set; }
        public int RecordId { get; set; }
        public int? IdOrder { get; set; }
        public string НомерКонтейнера { get; set; }
        public int? IdReestra { get; set; }
        public int? IdВидаУслуги { get; set; }
        public int? IdReestraPay { get; set; }
    }
}
