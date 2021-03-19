using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НезавершенныеЗаказыТоварBg
    {
        public int? IdPlantType42 { get; set; }
        public int НомерПокупателя { get; set; }
        public DateTime Дата { get; set; }
        public float SumКоличество { get; set; }
        public double? SumКоличествоЕвро { get; set; }
        public decimal? КоличествоСдано { get; set; }
        public string Наименование { get; set; }
        public string Фамилия { get; set; }
        public decimal? Доходность { get; set; }
        public decimal? Inv { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public float? КоличествоЖелаемое { get; set; }
        public double? ЦпОстаток { get; set; }
        public string Товар { get; set; }
        public string Артикул { get; set; }
        public decimal? Ssr { get; set; }
        public decimal? Цена { get; set; }
        public string OrderNo { get; set; }
        public string Статус { get; set; }
        public string StatTov { get; set; }
    }
}
