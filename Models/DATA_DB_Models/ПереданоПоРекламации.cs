using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПереданоПоРекламации
    {
        public string НомерЗаказа { get; set; }
        public int? НомерРекламации { get; set; }
        public string Артикул { get; set; }
        public decimal? Количество { get; set; }
        public DateTime? ДатаПрихода { get; set; }
        public string Завод { get; set; }
        public int? Закачено { get; set; }
    }
}
