using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class DlaPlanaTmp
    {
        public string Фамилия { get; set; }
        public string Клиент { get; set; }
        public string Юрлицо { get; set; }
        public int? НомерСчета { get; set; }
        public DateTime? ДатаСчета { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public DateTime? ДатаОплатыПоПлану { get; set; }
        public double? СрокОплаты { get; set; }
        public int? КолДнейДоОплаты { get; set; }
        public double? ДолгПоСчетуРуб { get; set; }
        public string НомерНакл { get; set; }
        public int? IdДилераЦо { get; set; }
        public string Дилер { get; set; }
    }
}
