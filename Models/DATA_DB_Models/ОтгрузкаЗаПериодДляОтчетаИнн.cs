using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгрузкаЗаПериодДляОтчетаИнн
    {
        public int IdДилера { get; set; }
        public decimal? Отгрузка { get; set; }
        public int UserId { get; set; }
        public int? КолМесяцев { get; set; }
        public int? РегионЦо { get; set; }
        public decimal? ОтгрЦр { get; set; }
        public decimal? ОтгрСс { get; set; }
        public decimal? СредневзвСкидка { get; set; }
        public decimal? Expr1 { get; set; }
        public decimal? Отгр3Мес { get; set; }
        public string Дилер { get; set; }
    }
}
