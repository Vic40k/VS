using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПрогнозПродажТмпРегион
    {
        public int IdТовара { get; set; }
        public decimal? Продажи { get; set; }
        public string Регионы { get; set; }
        public int? UserId { get; set; }
        public decimal? Выставка { get; set; }
        public decimal? ОстатокНаФил { get; set; }
        public decimal? ВПути { get; set; }
        public decimal? Отгр2 { get; set; }
        public decimal? Отгр3 { get; set; }
        public decimal? Подтв { get; set; }
        public decimal? ОтгрПоСсСпр { get; set; }
        public decimal? РеализацияЗаГод { get; set; }
        public int RecordId { get; set; }
    }
}
