using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КонстантыДляСебестоимости
    {
        public int? Номер { get; set; }
        public string Константа { get; set; }
        public decimal ЗначениеСейфы { get; set; }
        public decimal ЗначениеМебель { get; set; }
        public decimal ЗначениеДвери { get; set; }
        public decimal ЗначениеСтул { get; set; }
        public int? Площадка { get; set; }
        public string Согласовал1 { get; set; }
        public string Согласовал2 { get; set; }
        public string Согласовал3 { get; set; }
        public string Согласовал4 { get; set; }
        public decimal ЗначениеСтеллажи { get; set; }
        public decimal ЗначениеМедМебель { get; set; }
        public decimal ЗначениеПромМебель { get; set; }
        public string Согласовал5 { get; set; }
        public string Согласовал6 { get; set; }
        public string Согласовал7 { get; set; }
    }
}
