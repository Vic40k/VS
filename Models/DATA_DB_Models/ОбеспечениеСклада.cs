using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОбеспечениеСклада
    {
        public DateTime? Дата { get; set; }
        public decimal? Процент { get; set; }
        public string Площадка { get; set; }
        public string Статус { get; set; }
        public int? КолМоделей { get; set; }
        public int? КолСвободно { get; set; }
        public string Категория { get; set; }
        public decimal? Мз { get; set; }
        public decimal? ОтгрузкаЗа8Недель { get; set; }
        public int? IdТовара { get; set; }
        public int? Регион { get; set; }
        public decimal? МзДн { get; set; }
        public decimal? МзКол { get; set; }
        public decimal? ДзРуб { get; set; }
    }
}
