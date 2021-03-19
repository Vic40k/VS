using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОстаткиПоЗаявкам
    {
        public int Номер { get; set; }
        public decimal? Расход { get; set; }
        public int IdДилера { get; set; }
        public byte UsdRu { get; set; }
        public DateTime? Отгружена { get; set; }
        public int? Накладная { get; set; }
        public decimal? Поступление { get; set; }
        public decimal? РасходДол { get; set; }
        public decimal? ПоступлениеДол { get; set; }
        public string Наименование { get; set; }
        public string Инн { get; set; }
        public string НомерНакл { get; set; }
        public int? IdФирмы { get; set; }
        public int? Отсрочка { get; set; }
        public string КодГорода { get; set; }
    }
}
