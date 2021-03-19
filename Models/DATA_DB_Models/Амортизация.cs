using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Амортизация
    {
        public int Код1 { get; set; }
        public int? Год { get; set; }
        public int? Месяц { get; set; }
        public string Код { get; set; }
        public string Наименование { get; set; }
        public double? ЗначениеCим { get; set; }
        public double? ЗначениеЗмк { get; set; }
        public double? ЗначениеТпо { get; set; }
        public double? ЗначениеDib { get; set; }
        public double? ЗначениеOae { get; set; }
        public double? ЗначениеBlg { get; set; }
        public double? ЗначениеКитай { get; set; }
        public double? ЗначениеКзх { get; set; }
        public double? ЗначениеГрм { get; set; }
        public int BlgTip { get; set; }
        public double? ЗначениеCимБндс { get; set; }
        public double? ЗначениеЗмкБндс { get; set; }
        public double? ЗначениеТпоБндс { get; set; }
        public double? ЗначениеDibБндс { get; set; }
        public double? ЗначениеOaeБндс { get; set; }
        public double? ЗначениеBlgБндс { get; set; }
        public double? ЗначениеКитайБндс { get; set; }
        public double? ЗначениеКзхБндс { get; set; }
        public double? ЗначениеГрмБндс { get; set; }
        public double? ЗначениеСейфы { get; set; }
        public double? ЗначениеМебель { get; set; }
        public double? ЗначениеДвери { get; set; }
        public double? ЗначениеОбщие { get; set; }
        public double? ЗначениеНовое { get; set; }
        public double? ЗначениеПрочее { get; set; }
        public double? ЗначениеМебПрфМа { get; set; }
        public double? ЗначениеМо { get; set; }
        public int? IdПодразделения { get; set; }
        public double? ЗначениеМедмебель { get; set; }
        public double? ЗначениеСтеллажи { get; set; }
    }
}
