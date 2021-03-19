using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляРаспискиФормаКнРегион
    {
        public int Выражение1 { get; set; }
        public string Выражение2 { get; set; }
        public string Percent { get; set; }
        public int IdДилера { get; set; }
        public int Номер { get; set; }
        public DateTime? ДатаПр { get; set; }
        public int Склад { get; set; }
        public DateTime? ДатаПлатежки { get; set; }
        public int Накладная { get; set; }
        public decimal? Долг { get; set; }
        public DateTime Дата { get; set; }
        public bool ВидОплаты { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаR { get; set; }
        public string НомерПлатежки { get; set; }
        public decimal? СуммаРезервДол { get; set; }
        public decimal? СуммаРезервРуб { get; set; }
        public int RecordId { get; set; }
        public byte? ВидПлатежа { get; set; }
        public int Наличные { get; set; }
        public int Регион { get; set; }
        public decimal? ВСчете { get; set; }
        public int НомерПорядковый { get; set; }
        public string Год { get; set; }
    }
}
