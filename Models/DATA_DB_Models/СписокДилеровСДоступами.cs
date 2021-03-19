using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДилеровСДоступами
    {
        public int Id { get; set; }
        public string Наименование { get; set; }
        public string Название { get; set; }
        public string УлицаДом { get; set; }
        public short? Посредник { get; set; }
        public double? МаксимальныйКредитR { get; set; }
        public int Скидка { get; set; }
        public string ПолеПустое { get; set; }
        public string ПолеПустое1 { get; set; }
        public decimal? СкидкаПлан1 { get; set; }
        public decimal? СкидкаПлан2 { get; set; }
        public decimal Ндс { get; set; }
        public bool? ВыпискаОтПромет { get; set; }
        public int? СкидкаИзКарточки { get; set; }
        public int Менеджер { get; set; }
        public string Пусто1 { get; set; }
        public string Пусто2 { get; set; }
        public int IdДилОбъединения { get; set; }
        public int? IdВладельца { get; set; }
        public int Expr1 { get; set; }
        public int? IdРаботничкаРег { get; set; }
        public string Password { get; set; }
        public int? IdРаботничка { get; set; }
    }
}
