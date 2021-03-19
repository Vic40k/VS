using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДолгПоЗаявкеТмпРегион1111
    {
        public int НомерЗ { get; set; }
        public decimal? Долг { get; set; }
        public int Userid { get; set; }
        public int Регион { get; set; }
        public decimal? СуммаДоСкидки { get; set; }
        public decimal? СуммаСчета { get; set; }
        public decimal? Сейфы { get; set; }
        public decimal? Мебель { get; set; }
        public decimal? Двери { get; set; }
        public decimal? ДолгПоСчетуВал { get; set; }
        public string Валюта { get; set; }
        public decimal? СуммаСчетаВал { get; set; }
        public decimal? ДолгПоОтгр { get; set; }
        public decimal? ДолгПоОтгрВал { get; set; }
    }
}
