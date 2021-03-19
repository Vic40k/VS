using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СостояниеСклада
    {
        public string Наименование { get; set; }
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public short? ОтрицательноеКолВо { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? БазоваяЦена { get; set; }
        public decimal? БазоваяЦенаРуб { get; set; }
        public decimal? Pri { get; set; }
        public decimal? Ras { get; set; }
        public int? GroupOfGoods { get; set; }
        public string КодТовара { get; set; }
        public decimal? RasVse { get; set; }
        public decimal? Vputi { get; set; }
        public int Vputikl { get; set; }
    }
}
