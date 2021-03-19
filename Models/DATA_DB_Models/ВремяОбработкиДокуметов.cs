using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВремяОбработкиДокуметов
    {
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public DateTime? ОтгруженаВых { get; set; }
        public DateTime? Отгружена { get; set; }
        public string Expr1 { get; set; }
        public string Password { get; set; }
    }
}
