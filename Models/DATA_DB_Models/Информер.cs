using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Информер
    {
        public string ДеньНедели { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public int? НомерЗаявки { get; set; }
        public string Менеджер { get; set; }
        public string Направление { get; set; }
        public decimal? Объем { get; set; }
        public string Статус { get; set; }
        public string ВидОтгрузки { get; set; }
        public decimal? КСл { get; set; }
        public decimal? Итого { get; set; }
        public string Примечание { get; set; }
        public DateTime? ДатаРед { get; set; }
        public int? UserId { get; set; }
        public int RecordId { get; set; }
    }
}
