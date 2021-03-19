using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляОплатыРублиРегион
    {
        public int Выражение1 { get; set; }
        public string Накладная { get; set; }
        public DateTime Дата { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаR { get; set; }
        public int Percent { get; set; }
        public int IdДилера { get; set; }
        public int Номер { get; set; }
        public DateTime? Отпущена { get; set; }
        public int Склад { get; set; }
        public bool ВидОплаты { get; set; }
        public decimal? SumСуммаОплаты { get; set; }
        public decimal? SumСуммаОплатыR { get; set; }
        public int Регион { get; set; }
    }
}
