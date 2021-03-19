using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КанбанТмп
    {
        public string Наименование { get; set; }
        public int? IdТовара { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? Pri { get; set; }
        public decimal? Ras { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public string КодТовара { get; set; }
        public decimal? Vputi { get; set; }
        public decimal? Vputikl { get; set; }
        public decimal? Red { get; set; }
        public decimal? Yellow { get; set; }
        public decimal? Stop { get; set; }
        public decimal? _1дн { get; set; }
        public decimal? _2Дн { get; set; }
        public decimal? _3дн { get; set; }
        public decimal? _1Дн1 { get; set; }
        public decimal? _2Дн1 { get; set; }
        public decimal? _3Дн1 { get; set; }
    }
}
