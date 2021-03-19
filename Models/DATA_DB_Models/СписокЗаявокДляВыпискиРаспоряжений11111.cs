using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляВыпискиРаспоряжений11111
    {
        public int Номер { get; set; }
        public string Наименование { get; set; }
        public DateTime Дата { get; set; }
        public bool ВыписаноРаспоряжение { get; set; }
        public int Склад { get; set; }
        public bool Оплачена { get; set; }
        public bool Аннулирована { get; set; }
        public int IdДилера { get; set; }
        public bool УсловияПоставки { get; set; }
        public byte UsdRu { get; set; }
        public bool ВидОплаты { get; set; }
        public int? IdФирмы { get; set; }
        public int? Менеджер { get; set; }
        public DateTime? Expr1 { get; set; }
        public int? IdЮрлица { get; set; }
        public DateTime Expr2 { get; set; }
        public int Секретно { get; set; }
    }
}
