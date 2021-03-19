using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КарточкаРасходРегион
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public DateTime? ДатаЗаписи { get; set; }
        public decimal Отпущено { get; set; }
        public int? НомерПорядковый { get; set; }
        public int? Номер { get; set; }
        public string НомерНакл { get; set; }
        public string Клиент { get; set; }
        public string Склад { get; set; }
        public DateTime? Дата { get; set; }
        public int RecordId { get; set; }
        public int? НомерСчета { get; set; }
        public short? Префикс { get; set; }
        public decimal? Недогружено { get; set; }
        public int Регион { get; set; }
        public int UserId { get; set; }
        public decimal КоличествоОплаченное { get; set; }
        public string Год { get; set; }
        public byte? УсловияПоставки { get; set; }
        public byte? Подтвержден { get; set; }
        public int? RecordРекламация { get; set; }
        public decimal Подтверждено { get; set; }
    }
}
