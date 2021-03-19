using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДляПрайсЛистаРегион
    {
        public string Наименование { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public int IdТовара { get; set; }
        public decimal? PriceMin { get; set; }
        public string КодТовара { get; set; }
        public string Группа { get; set; }
        public string Подгруппа { get; set; }
        public string Статус { get; set; }
        public int Неликвид { get; set; }
        public int Регион { get; set; }
        public double? ВесБрутто { get; set; }
        public double? Объем { get; set; }
    }
}
