using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПроектов
    {
        public int IdПроекта { get; set; }
        public string КодПроекта { get; set; }
        public string Наименование { get; set; }
        public string Руководитель { get; set; }
        public DateTime? ДатаНачала { get; set; }
        public DateTime? ДатаОкончания { get; set; }
        public double? Бюджет { get; set; }
        public int? Подразделение { get; set; }
        public bool? Deleted { get; set; }
    }
}
