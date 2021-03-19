using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПредложенияОхотников
    {
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public string Комментарий { get; set; }
        public int UserId { get; set; }
        public double? Цена { get; set; }
        public int? Поставщик { get; set; }
        public int НомерЗаявки { get; set; }
        public bool? Выбрано { get; set; }
        public string Критерий1 { get; set; }
        public string Критерий2 { get; set; }
        public string Критерий3 { get; set; }
        public string Критерий4 { get; set; }
        public string Критерий5 { get; set; }
        public string Критерий6 { get; set; }
        public string Критерий7 { get; set; }
        public string Критерий8 { get; set; }
        public string Критерий9 { get; set; }
        public string Критерий10 { get; set; }
        public string Значение1 { get; set; }
        public string Значение2 { get; set; }
        public string Значение3 { get; set; }
        public string Значение4 { get; set; }
        public string Значение5 { get; set; }
        public string Значение6 { get; set; }
        public string Значение7 { get; set; }
        public string Значение8 { get; set; }
        public string Значение9 { get; set; }
        public string Значение10 { get; set; }
        public string Ед1 { get; set; }
        public string Ед2 { get; set; }
        public string Ед3 { get; set; }
        public string Ед4 { get; set; }
        public string Ед5 { get; set; }
        public string Ед6 { get; set; }
        public string Ед7 { get; set; }
        public string Ед8 { get; set; }
        public string Ед9 { get; set; }
        public string Ед10 { get; set; }
    }
}
