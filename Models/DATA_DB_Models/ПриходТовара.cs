using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходТовара
    {
        public int RecordId { get; set; }
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public decimal Количество { get; set; }
        public DateTime? ДатаПрихода { get; set; }
        public int UserId { get; set; }
        public int Заявка { get; set; }
        public string Поставщик { get; set; }
        public string НаименованиеОперации { get; set; }
        public string Документ { get; set; }
        public string Ордер { get; set; }
        public DateTime? ДатаРасчетная { get; set; }
        public decimal? Префикс { get; set; }
        public decimal? Sebestoimost { get; set; }
        public decimal? Ssr { get; set; }
        public decimal? Цп { get; set; }
        public int? Перекачать { get; set; }
        public int? НомерЗаказа { get; set; }
        public int? РегионЗаказа { get; set; }
        public int? RecordРекламация { get; set; }
        public short? Оценка1 { get; set; }
        public short? Оценка2 { get; set; }
        public short? Оценка3 { get; set; }
        public short? Оценка4 { get; set; }
        public short? Оценка5 { get; set; }
        public short? Оценка6 { get; set; }
        public short? Оценка7 { get; set; }
        public short? Оценка8 { get; set; }
        public short? Оценка9 { get; set; }
        public int? НомерРекламации { get; set; }
    }
}
