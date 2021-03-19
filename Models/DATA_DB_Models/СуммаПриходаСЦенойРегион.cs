using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СуммаПриходаСЦенойРегион
    {
        public int IdТовара { get; set; }
        public decimal? SumOfКоличество { get; set; }
        public int IdСклада { get; set; }
        public decimal? БазоваяЦена { get; set; }
        public decimal? Vputi { get; set; }
        public decimal? Цена { get; set; }
        public decimal? Скидка { get; set; }
        public int Регион { get; set; }
    }
}
