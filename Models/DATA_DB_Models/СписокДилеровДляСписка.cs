using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДилеровДляСписка
    {
        public int Expr1 { get; set; }
        public string Название { get; set; }
        public string Город { get; set; }
        public double? Кредит { get; set; }
        public double? Товар { get; set; }
        public int Expr2 { get; set; }
        public int Менеджер { get; set; }
        public string Фамилия { get; set; }
        public int? IdРаботничка { get; set; }
        public string Наименование { get; set; }
        public int? IdЮрлица { get; set; }
        public int? IdВладельца { get; set; }
        public string Инн { get; set; }
    }
}
