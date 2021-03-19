using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгрузкаЗаПериодДляОтчетаРегион
    {
        public int IdДилера { get; set; }
        public decimal? ОплатаРуб { get; set; }
        public int? UserId { get; set; }
        public int? Регион { get; set; }
        public int? КолМесяцев { get; set; }
        public decimal? ОтгрЦр { get; set; }
        public decimal? ОтгрСс { get; set; }
        public string КаналСбыта { get; set; }
        public string Объединенный { get; set; }
        public int? IdОбъед { get; set; }
        public decimal? Отгрузка3Мес { get; set; }
        public string Дилер { get; set; }
    }
}
