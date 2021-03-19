using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПланПлатежейЦоЗаготовка
    {
        public string Фамилия { get; set; }
        public string Дилер { get; set; }
        public string Юрлицо { get; set; }
        public int НомерСчета { get; set; }
        public DateTime ДатаСчета { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public DateTime? ДатаОплатыПоПлану { get; set; }
        public int? Отсрочка { get; set; }
        public DateTime? КолДнейДоОплаты { get; set; }
        public string НомерНакл { get; set; }
        public int? IdРаботничка { get; set; }
        public int? Менеджер { get; set; }
        public int? IdВладельца { get; set; }
        public int IdДилера { get; set; }
        public string КаналСбыта { get; set; }
        public string Фирма { get; set; }
        public string Рс { get; set; }
    }
}
