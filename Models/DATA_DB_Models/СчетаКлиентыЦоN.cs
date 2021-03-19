using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СчетаКлиентыЦоN
    {
        public string Наименование { get; set; }
        public DateTime? Дата { get; set; }
        public int Expr1 { get; set; }
        public bool Оплачен { get; set; }
        public int Номер { get; set; }
        public int? Склад { get; set; }
        public int? IdФирмы { get; set; }
        public int? ВнешнийНомер { get; set; }
        public DateTime? ВнешняяДата { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public DateTime? ДатаПредполагаемойПродажи { get; set; }
        public int? Накладная { get; set; }
        public bool Изменен { get; set; }
        public string Фамилия { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string Маршрут { get; set; }
        public string Стадия { get; set; }
        public string НомерНакл { get; set; }
        public string Водитель { get; set; }
    }
}
