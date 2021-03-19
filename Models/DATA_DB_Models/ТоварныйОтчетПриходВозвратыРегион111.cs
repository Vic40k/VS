using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетПриходВозвратыРегион111
    {
        public DateTime? ДатаПрихода { get; set; }
        public int Документ { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public decimal Количество { get; set; }
        public int Регион { get; set; }
        public int Склад { get; set; }
        public int ЗаводСклад { get; set; }
    }
}
