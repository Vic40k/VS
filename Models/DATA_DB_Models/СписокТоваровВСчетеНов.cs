using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоваровВСчетеНов
    {
        public int НомерПокупателя { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public decimal Количество { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal? Цена { get; set; }
        public string КодТовара { get; set; }
        public decimal Sebestoimost { get; set; }
        public decimal? Nds { get; set; }
        public decimal БазоваяЦенаRДоДоп { get; set; }
        public double? Объем { get; set; }
        public double? Вес { get; set; }
        public decimal? ПроцСкидки { get; set; }
        public decimal БазоваяЦенаR { get; set; }
    }
}
