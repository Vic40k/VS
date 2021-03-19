using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДляБлокировки
    {
        public string Наименование { get; set; }
        public string Наименование1 { get; set; }
        public string Наименование2 { get; set; }
        public string ФиоДиректора { get; set; }
        public string ФиоВладельца1 { get; set; }
        public string ФиоВладельца2 { get; set; }
        public DateTime? ДатаРожденияДиректора { get; set; }
        public DateTime? ДатаРожденияВладельца1 { get; set; }
        public DateTime? ДатаРожденияВладельца2 { get; set; }
        public int? Менеджер { get; set; }
        public int? Город { get; set; }
        public int? Дилер { get; set; }
        public string Инн { get; set; }
    }
}
