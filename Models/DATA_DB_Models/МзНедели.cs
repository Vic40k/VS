using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class МзНедели
    {
        public DateTime ПериодОд { get; set; }
        public DateTime ПериодДо { get; set; }
        public string Группа { get; set; }
        public string Подгруппа { get; set; }
        public string Основной { get; set; }
        public string Наименование { get; set; }
        public string КодТовара { get; set; }
        public decimal МзГлНп { get; set; }
        public decimal МзФилНп { get; set; }
        public decimal МзУзмкНп { get; set; }
        public decimal МзDibНп { get; set; }
        public decimal МзТтНп { get; set; }
        public decimal ВыпускГл { get; set; }
        public decimal ВыпускУзмк { get; set; }
        public decimal ВыпускБолгария { get; set; }
        public decimal ВыпускDib { get; set; }
        public decimal ПродажиРф { get; set; }
        public decimal ПродажиDib { get; set; }
        public int IdТовара { get; set; }
        public int? Категория { get; set; }
        public decimal ПродажиЗаГод { get; set; }
        public decimal СписаноВОф { get; set; }
    }
}
