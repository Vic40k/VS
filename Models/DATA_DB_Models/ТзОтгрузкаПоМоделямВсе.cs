using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТзОтгрузкаПоМоделямВсе
    {
        public int? IdТовара { get; set; }
        public string ПодГруппа { get; set; }
        public decimal? Количество { get; set; }
        public decimal? СуммаРуб { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? Себестоимость { get; set; }
        public decimal? СебестоимостьРуб { get; set; }
        public int? UserId { get; set; }
        public string Филиал { get; set; }
    }
}
