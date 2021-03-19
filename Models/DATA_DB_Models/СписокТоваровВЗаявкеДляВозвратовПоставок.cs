using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоваровВЗаявкеДляВозвратовПоставок
    {
        public int IdДилера { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public decimal? SumКоличество { get; set; }
        public decimal? LastЦенаПродажи { get; set; }
        public decimal? LastЦенаПродажиR { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? LastSebestoimost { get; set; }
        public decimal? SumКоличествоДляОтгрузки { get; set; }
        public decimal? LastSsr { get; set; }
    }
}
