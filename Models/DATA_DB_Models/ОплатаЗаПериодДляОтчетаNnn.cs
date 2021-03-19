using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатаЗаПериодДляОтчетаNnn
    {
        public int IdДилера { get; set; }
        public decimal? ОплатаРуб { get; set; }
        public int UserId { get; set; }
        public DateTime? ДатаНачОпл { get; set; }
        public DateTime? ДатаКонОпл { get; set; }
        public int? КолМесяцев { get; set; }
        public int? Dil { get; set; }
        public int Rec { get; set; }
        public string Дилер { get; set; }
        public int? IdОбъед { get; set; }
    }
}
