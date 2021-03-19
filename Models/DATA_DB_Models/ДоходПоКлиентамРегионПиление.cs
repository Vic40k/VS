using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДоходПоКлиентамРегионПиление
    {
        public string Наименование { get; set; }
        public string Менеджер { get; set; }
        public decimal? Выручка { get; set; }
        public decimal? Сс { get; set; }
        public decimal? Доход { get; set; }
        public decimal? ВыручкаР { get; set; }
        public decimal? ДоходР { get; set; }
        public string Название { get; set; }
        public DateTime? ДатаПр { get; set; }
        public int? Регион { get; set; }
        public string Кому { get; set; }
        public decimal? ВыручкаБезНдс { get; set; }
        public decimal? ДоходБезНдс { get; set; }
        public decimal? ВыручкаWeb { get; set; }
        public decimal? ДоходСколько { get; set; }
        public string ОтКого { get; set; }
    }
}
