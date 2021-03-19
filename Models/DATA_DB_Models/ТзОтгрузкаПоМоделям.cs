using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТзОтгрузкаПоМоделям
    {
        public int? Год { get; set; }
        public int? Месяц { get; set; }
        public string Группа { get; set; }
        public string Подгруппа { get; set; }
        public string Модель { get; set; }
        public decimal? СуммаРуб { get; set; }
        public decimal? Количество { get; set; }
        public int? UserId { get; set; }
        public int? IdТовара { get; set; }
        public int? Неделя { get; set; }
        public int? Рег { get; set; }
        public int Rec { get; set; }
    }
}
