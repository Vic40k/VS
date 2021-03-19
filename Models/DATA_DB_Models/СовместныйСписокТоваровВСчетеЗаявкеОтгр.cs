using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СовместныйСписокТоваровВСчетеЗаявкеОтгр
    {
        public string Наименование { get; set; }
        public int НомерПокупателя { get; set; }
        public decimal Количество { get; set; }
        public byte ДилерКлиент { get; set; }
        public string Артикул { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
        public short? Префикс { get; set; }
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public string КодЗаказа { get; set; }
        public int? Причина { get; set; }
        public int RecordId { get; set; }
        public string УпаковкаНомер { get; set; }
        public string ПаллетаНомер { get; set; }
        public decimal? РасчетноеКоличество { get; set; }
        public int? КоличествоВЕдинице { get; set; }
        public short КоличествоВУпаковке { get; set; }
        public int? ФактМест { get; set; }
        public string КодТовара { get; set; }
    }
}
