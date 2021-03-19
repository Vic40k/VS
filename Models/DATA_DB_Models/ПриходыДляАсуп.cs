using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходыДляАсуп
    {
        public DateTime? ДатаПрихода { get; set; }
        public string КодВ1с { get; set; }
        public string Наименование { get; set; }
        public decimal? Цена { get; set; }
        public decimal Количество { get; set; }
        public string Склад { get; set; }
        public string ЕдИзм { get; set; }
        public string Артикул { get; set; }
        public int IdТовара { get; set; }
        public string АртикулНовый { get; set; }
        public int FactoryId { get; set; }
    }
}
