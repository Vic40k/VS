using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Распоряжения
    {
        public int Номер { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public int? НомерСчета { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public string ДоверенностьДата { get; set; }
        public byte? ДилерКлиент { get; set; }
        public int? Idfirm { get; set; }
        public int? UserId { get; set; }
        public int? ВнешнийНомер { get; set; }
        public DateTime? ВнешняяДата { get; set; }
        public int? Причина { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int? Фирма { get; set; }
        public int? IdСтадии { get; set; }
        public decimal? Затраты { get; set; }
        public string Водитель { get; set; }
        public int? IdВодителя { get; set; }
        public int? IdПункта { get; set; }
        public int? IdВидаТранспорта { get; set; }
    }
}
