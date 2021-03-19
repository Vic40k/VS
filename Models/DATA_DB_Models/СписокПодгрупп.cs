using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПодгрупп
    {
        public int IdПодгруппы { get; set; }
        public int? IdГруппы { get; set; }
        public string Наименование { get; set; }
        public int? КодСортировки { get; set; }
        public int Категория { get; set; }
        public int? Контролировать { get; set; }
        public decimal? KfХранения { get; set; }
        public int? Реагирование { get; set; }
        public int? Red { get; set; }
        public int? Yellow { get; set; }
        public int? Stop { get; set; }
        public int? РеагированиеУзмк { get; set; }
        public int? RedУзмк { get; set; }
        public int? YellowУзмк { get; set; }
        public int? StopУзмк { get; set; }
        public int? МаксимальнаяДатаПлана { get; set; }
        public string ТоварнаяГруппа { get; set; }
    }
}
