using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварыДляГлСклада
    {
        public string Наименование { get; set; }
        public int IdТовара { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? Pri { get; set; }
        public decimal? Ras { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public decimal? Разница { get; set; }
        public string КодТовара { get; set; }
        public decimal? Vputi { get; set; }
        public int Vputikl { get; set; }
        public int IdСклада { get; set; }
    }
}
