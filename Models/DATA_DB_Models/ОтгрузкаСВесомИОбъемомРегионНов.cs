using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгрузкаСВесомИОбъемомРегионНов
    {
        public decimal? Реализация { get; set; }
        public decimal? КолР { get; set; }
        public decimal? SsrRasБезНдс { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public double? Вес { get; set; }
        public double? Об { get; set; }
        public string Категория { get; set; }
        public decimal ЦпТула { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public int НомерПокупателя { get; set; }
        public int IdТовара { get; set; }
        public string Кому { get; set; }
        public decimal? Амортизация { get; set; }
        public decimal БазоваяЦена { get; set; }
        public decimal? РеализацияСсБезНдс { get; set; }
        public int IdСклада { get; set; }
        public int? НомерЗаказа { get; set; }
    }
}
