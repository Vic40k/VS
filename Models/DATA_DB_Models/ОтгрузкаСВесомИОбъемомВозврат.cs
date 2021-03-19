using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгрузкаСВесомИОбъемомВозврат
    {
        public decimal? КолР { get; set; }
        public decimal? SsrRasБезНдс { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public double? Вес { get; set; }
        public double? Об { get; set; }
        public string Категория { get; set; }
        public decimal? ЦпСосенки { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string Документ { get; set; }
        public int IdТовара { get; set; }
    }
}
