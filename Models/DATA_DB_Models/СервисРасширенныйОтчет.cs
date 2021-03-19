using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СервисРасширенныйОтчет
    {
        public DateTime? ДатаВвода { get; set; }
        public int RecordId { get; set; }
        public string Код { get; set; }
        public string Наименование { get; set; }
        public string Поставщик { get; set; }
        public string Хар { get; set; }
        public string ОписаниеДефекта { get; set; }
        public decimal? ФинансовыеПотери { get; set; }
        public int? ТипКлиента { get; set; }
        public string Expr1 { get; set; }
        public bool ВыездМастера { get; set; }
        public string ОтчетЗмк { get; set; }
        public string КомуПереданоЗмк { get; set; }
        public string Замок { get; set; }
        public bool? НеУчтеноЗмк { get; set; }
        public string Srok { get; set; }
        public int? Количество { get; set; }
        public string ТипПродукции { get; set; }
        public DateTime? ДатаАкта { get; set; }
        public string КодДефекта { get; set; }
        public string Филиал { get; set; }
        public bool Дилер { get; set; }
        public string СерийныйНомер { get; set; }
        public DateTime? ДатаИзделия { get; set; }
        public string ШтампОтк { get; set; }
        public string КлеймоИсполнителя { get; set; }
        public string НеобходимыеЗЧ { get; set; }
        public string ПереданныеЗЧ { get; set; }
        public string КорректирующиеДействия { get; set; }
        public string Затрата { get; set; }
        public int? IdТовара { get; set; }
        public DateTime? ДатаИсполнения { get; set; }
        public DateTime? ДатаИсполненияПоПлану { get; set; }
        public decimal? ЗатратыСклада { get; set; }
        public decimal? ЗатратыТранспортировки { get; set; }
        public DateTime? ДатаЗакрытоФилиалом { get; set; }
        public decimal? ЗатратыФилиала { get; set; }
        public string Артикул { get; set; }
        public string Решение { get; set; }
        public string РекламацияПризнана { get; set; }
        public string ПринятоеРешение { get; set; }
        public string АктРассмотренияРекламации { get; set; }
        public string КодПоддефекта { get; set; }
        public string СкладОтгрузки { get; set; }
        public decimal? SsrБезНдс { get; set; }
    }
}
