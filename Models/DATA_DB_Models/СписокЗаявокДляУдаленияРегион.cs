using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляУдаленияРегион
    {
        public string Наименование { get; set; }
        public int НомерСчетаРегион { get; set; }
        public DateTime Дата { get; set; }
        public int Номер { get; set; }
        public int IdДилера { get; set; }
        public int Регион { get; set; }
        public decimal Total { get; set; }
        public int? IdПеревозчика { get; set; }
        public double? Доступ { get; set; }
        public string Примечание { get; set; }
    }
}
