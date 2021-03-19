using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПоЗаявкамДляРаспискиРегион
    {
        public int Номер { get; set; }
        public byte? FirstОбоснованиеБлокировки { get; set; }
        public decimal? Сумма { get; set; }
        public double? СуммаR { get; set; }
        public DateTime Дата { get; set; }
        public int IdДилера { get; set; }
        public int Склад { get; set; }
        public decimal Отсрочка { get; set; }
        public bool ВидОплаты { get; set; }
        public byte UsdRu { get; set; }
        public int IdФирмы { get; set; }
        public int Регион { get; set; }
        public double? ВСчете { get; set; }
        public int? KlientReg { get; set; }
        public int RecKl { get; set; }
    }
}
