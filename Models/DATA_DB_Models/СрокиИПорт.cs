using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СрокиИПорт
    {
        public string НомерЗаказа { get; set; }
        public string НомерИнвойсаТип1 { get; set; }
        public string ПеревозИк { get; set; }
        public string Порт { get; set; }
        public decimal? УбыткиЗаПростойФакт { get; set; }
        public string Прим { get; set; }
        public DateTime? ДатаВнесенияИзменеий { get; set; }
        public string КтоВнес { get; set; }
        public int? IdOrder { get; set; }
        public int Id { get; set; }
    }
}
