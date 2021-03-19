using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РегистрацияПриемокПоКачеству
    {
        public int RecordId { get; set; }
        public int? IdТовара { get; set; }
        public string НомерАкта { get; set; }
        public DateTime? Дата { get; set; }
        public string ОписаниеБрака { get; set; }
        public int? КодЗатрат { get; set; }
        public double? СуммаЗатрат { get; set; }
        public int? ПринятоеРешение { get; set; }
        public string ОтКого { get; set; }
        public bool? ОтметкаОбИсполнении { get; set; }
        public string НомерЗаказа { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public int? КтоВнес { get; set; }
    }
}
