using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспоряженияДвойные
    {
        public int Номер { get; set; }
        public int? Префикс { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public int? НомерСчета { get; set; }
        public int? ДилерКлиент { get; set; }
        public string Idfirm { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public string ДоверенностьДата { get; set; }
        public int RecordId { get; set; }
        public string КомуОтпустить { get; set; }
        public int? UserId { get; set; }
        public DateTime? ДатаПоПлану { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public int? Причина { get; set; }
        public int? IdСтадии { get; set; }
        public decimal? Затраты { get; set; }
        public string Водитель { get; set; }
        public int? IdВодителя { get; set; }
        public int? IdПункта { get; set; }
        public int? IdВидаТранспорта { get; set; }
    }
}
