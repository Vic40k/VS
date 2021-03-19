using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗПоказатели
    {
        public int Год { get; set; }
        public int Месяц { get; set; }
        public decimal ВыпускСосенка { get; set; }
        public decimal ВыпускУзмк { get; set; }
        public decimal ВыпускБолгария { get; set; }
        public decimal ДоходСосенка { get; set; }
        public decimal ДоходУзмк { get; set; }
        public decimal ДоходБолгария { get; set; }
        public decimal Продажи { get; set; }
        public decimal Доход { get; set; }
        public bool РасчетЗакончен { get; set; }
        public decimal ДоходСейфы { get; set; }
        public decimal ДоходМебель { get; set; }
        public decimal ДоходДвери { get; set; }
        public decimal ДоходDib { get; set; }
        public decimal ДоходDibМебель { get; set; }
    }
}
