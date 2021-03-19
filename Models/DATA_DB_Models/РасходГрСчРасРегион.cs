using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходГрСчРасРегион
    {
        public int НомерПокупателя { get; set; }
        public int IdТовара { get; set; }
        public decimal? Счет { get; set; }
        public decimal? Расход { get; set; }
        public decimal? ЦенаПродажи { get; set; }
        public decimal? ЦенаПродажиR { get; set; }
        public decimal? БазоваяЦена { get; set; }
        public decimal? БазоваяЦенаR { get; set; }
        public DateTime? ДатаПредполагаемойПродажи { get; set; }
        public decimal? Sebestoimost { get; set; }
        public decimal? FirstSsr { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public int IdСклада { get; set; }
        public int? FirstUserId { get; set; }
        public string Накладная { get; set; }
        public int Регион { get; set; }
        public decimal? Цр { get; set; }
        public decimal? Nds { get; set; }
        public decimal? БазоваяЦенаRДоДоп { get; set; }
        public decimal? SsrБезНдс { get; set; }
        public int? RecordРекламация { get; set; }
        public DateTime? ДатаРасчетная { get; set; }
        public int? Подтверждение { get; set; }
        public decimal? КоличествоОплаченное { get; set; }
    }
}
