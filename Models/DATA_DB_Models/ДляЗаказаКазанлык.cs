using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДляЗаказаКазанлык
    {
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public int IdТовара { get; set; }
        public string Модель { get; set; }
        public string КодТовара { get; set; }
        public string Основной { get; set; }
        public int? GroupOfGoods { get; set; }
    }
}
