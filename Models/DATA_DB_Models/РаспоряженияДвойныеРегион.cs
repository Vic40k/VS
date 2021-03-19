using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспоряженияДвойныеРегион
    {
        public int? Номер { get; set; }
        public short? Префикс { get; set; }
        public DateTime ДатаОтпуска { get; set; }
        public int НомерСчета { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public DateTime? ДоверенностьДата { get; set; }
        public byte ДилерКлиент { get; set; }
        public int RecordId { get; set; }
        public int? Idfirm { get; set; }
        public int UserId { get; set; }
        public int? ВнешнийНомер { get; set; }
        public DateTime? ВнешняяДата { get; set; }
        public DateTime? ДатаПоПлану { get; set; }
        public bool? Перенесена { get; set; }
        public bool? Перенести { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public int Регион { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int? IdСтадииРасп { get; set; }
        public int? IdВодителяРасп { get; set; }
        public int? IdПунктаРасп { get; set; }
        public int? IdПеревозчикаРасп { get; set; }
        public int? IdЗаказчикаТранспортаРасп { get; set; }
        public int? IdПричины { get; set; }
        public string НаименованиеГруза { get; set; }
        public int? IdВидаТранспорта { get; set; }
    }
}
