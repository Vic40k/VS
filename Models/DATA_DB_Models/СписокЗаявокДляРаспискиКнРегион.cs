using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляРаспискиКнРегион
    {
        public int Выражение1 { get; set; }
        public decimal? Выражение2 { get; set; }
        public int Percent { get; set; }
        public int IdДилера { get; set; }
        public int Номер { get; set; }
        public int Склад { get; set; }
        public decimal Отсрочка { get; set; }
        public int Накладная { get; set; }
        public DateTime Дата { get; set; }
        public bool ВидОплаты { get; set; }
        public decimal? Сумма { get; set; }
        public double? СуммаR { get; set; }
        public byte UsdRu { get; set; }
        public int IdФирмы { get; set; }
        public int Регион { get; set; }
        public double? ВСчете { get; set; }
        public decimal? Долг { get; set; }
    }
}
