using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКодовМоделей
    {
        public string Код { get; set; }
        public string Модель { get; set; }
        public short? КодТипа { get; set; }
        public string КодКатегории { get; set; }
        public string КодИзготовителя { get; set; }
        public string СтараяМодель { get; set; }
        public string Наименование { get; set; }
        public string СтароеНаименование { get; set; }
    }
}
