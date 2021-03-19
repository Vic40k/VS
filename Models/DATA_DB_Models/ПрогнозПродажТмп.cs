using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПрогнозПродажТмп
    {
        public int IdТовара { get; set; }
        public decimal? Продажи { get; set; }
        public string Регионы { get; set; }
        public int? UserId { get; set; }
        public decimal? ОстатокНаГл { get; set; }
        public decimal? ОстатокНаФил { get; set; }
        public decimal? ПереводНаДиб { get; set; }
        public decimal? ОтгрПоСсСпр { get; set; }
    }
}
