using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Контейнера
    {
        public string НомерЗаказа { get; set; }
        public string НомерКонтейнера { get; set; }
        public DateTime? ДатаПрибытияВПорт { get; set; }
        public double? ПростойВПортуСуток { get; set; }
        public DateTime? ДатаПрибытиеВМоскву { get; set; }
        public string Прим { get; set; }
        public DateTime? ДатаВнесенияИзменений { get; set; }
        public string КтоВнес { get; set; }
        public decimal? УбыткиЗаПростой { get; set; }
        public double? ПолученИлиНет { get; set; }
        public int IdOrder { get; set; }
        public int RecordId { get; set; }
    }
}
