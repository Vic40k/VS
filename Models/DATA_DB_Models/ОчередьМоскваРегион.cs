using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОчередьМоскваРегион
    {
        public string Клиент { get; set; }
        public string КодТовара { get; set; }
        public string Наименование { get; set; }
        public decimal Количество { get; set; }
        public int IdТовара { get; set; }
        public string Модель { get; set; }
        public string Артикул { get; set; }
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public string Фамилия { get; set; }
        public int? Разрешение { get; set; }
        public DateTime? ДатаРасчетная { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public DateTime? Expr1 { get; set; }
    }
}
