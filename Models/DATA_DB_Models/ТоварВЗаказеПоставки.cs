using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварВЗаказеПоставки
    {
        public int IdТовара { get; set; }
        public int НомерПокупателя { get; set; }
        public float Количество { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int UserId { get; set; }
        public int RecordId { get; set; }
    }
}
