using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтчетыДилерГруппаПодгруппаМодель
    {
        public string ГодМесяц { get; set; }
        public string Группа { get; set; }
        public string Подгруппа { get; set; }
        public string Модель { get; set; }
        public decimal? Руб { get; set; }
        public decimal? Штук { get; set; }
    }
}
