using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НоменклатураТоваровАртикул
    {
        public string Наименование { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public string КодТовара { get; set; }
        public string IdМодели { get; set; }
        public int? GroupOfGoods { get; set; }
        public int IdПодгруппы { get; set; }
        public int IdТовара { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public decimal Nds { get; set; }
        public bool Deleted { get; set; }
        public string Статус { get; set; }
        public short? ОтрицательноеКолВо { get; set; }
    }
}
