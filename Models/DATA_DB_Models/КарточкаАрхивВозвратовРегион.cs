using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КарточкаАрхивВозвратовРегион
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public string ДатаЗаписи { get; set; }
        public decimal? Отпущено { get; set; }
        public int НомерПрядковый { get; set; }
        public int Номер { get; set; }
        public string НомерНакл { get; set; }
        public string Клиент { get; set; }
        public string Склад { get; set; }
        public string Дата { get; set; }
        public int RecordId { get; set; }
        public int НомерСчета { get; set; }
        public int Префикс { get; set; }
        public int Недогружено { get; set; }
        public int Регион { get; set; }
        public int UserId { get; set; }
        public int КоличествоОплаченное { get; set; }
        public int Год { get; set; }
        public int УсловияПоставки { get; set; }
        public int Подтвержден { get; set; }
    }
}
