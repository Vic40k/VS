using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПогрузочныйЛистЕдиный
    {
        public int НомерСчета { get; set; }
        public string Кл { get; set; }
        public string КодГорода { get; set; }
        public string Накладная { get; set; }
        public string Наименование { get; set; }
        public decimal SumКоличество { get; set; }
        public int НомерПокупателя { get; set; }
        public short? Префикс { get; set; }
        public int Регион { get; set; }
        public string НомерНакл { get; set; }
        public string Артикул { get; set; }
        public string ПаллетаНомер { get; set; }
        public string КодРеквизита { get; set; }
        public string ДляКого { get; set; }
        public int? UserId { get; set; }
        public string Название { get; set; }
        public int IdТовара { get; set; }
    }
}
