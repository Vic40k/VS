using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспоряженияПоЗаявкам
    {
        public int? НомерСчета { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string ДоверенностьДата { get; set; }
        public int? UserId { get; set; }
        public int Номер { get; set; }
        public byte UsdRu { get; set; }
        public string Год { get; set; }
        public int? НомерПорядковый { get; set; }
    }
}
