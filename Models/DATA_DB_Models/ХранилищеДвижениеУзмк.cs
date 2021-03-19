using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ХранилищеДвижениеУзмк
    {
        public int RecordIdЯчейкиОткуда { get; set; }
        public int RecordIdЯчейкиКуда { get; set; }
        public int IdТовара { get; set; }
        public decimal КоличествоПришло { get; set; }
        public decimal КоличествоВышло { get; set; }
        public DateTime ДатаПомещения { get; set; }
        public DateTime? ДатаВыхода { get; set; }
        public int RecordId { get; set; }
        public int? Kto { get; set; }
        public string Заказ { get; set; }
        public int Регион { get; set; }
    }
}
