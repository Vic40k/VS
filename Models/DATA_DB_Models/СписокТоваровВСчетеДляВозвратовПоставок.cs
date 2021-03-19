using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоваровВСчетеДляВозвратовПоставок
    {
        public int IdДилера { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public decimal? SumКоличество { get; set; }
        public decimal? ЦенаПродажи { get; set; }
        public decimal? ЦенаПродажиR { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? LastSebestoimost { get; set; }
        public decimal? SumКоличествоДляОтгрузки { get; set; }
        public decimal? LastSsr { get; set; }
    }
}
