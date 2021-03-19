using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПоЗаявкамДляДолгаДляПлана
    {
        public int Номер { get; set; }
        public double? СуммаR { get; set; }
        public decimal? СуммаДол { get; set; }
        public string Password { get; set; }
        public decimal? Сейфы { get; set; }
        public decimal? Мебель { get; set; }
        public decimal? Двери { get; set; }
        public string Валюта { get; set; }
        public double? СуммаRОтгр { get; set; }
        public decimal? СуммаДолОтгр { get; set; }
        public string Название { get; set; }
    }
}
