using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PriceЦп
    {
        public int SafeId { get; set; }
        public decimal СсБезНдс { get; set; }
        public decimal Цп { get; set; }
        public decimal PriceMin { get; set; }
        public decimal Сс { get; set; }
        public string Артикул { get; set; }
        public int? GroupOfGoods { get; set; }
        public int IdПодгруппы { get; set; }
        public decimal? ЦенаУзмк { get; set; }
        public decimal? Амортизация { get; set; }
        public decimal? СредняяСкидка { get; set; }
        public decimal Sebestoimost { get; set; }
        public decimal ЦенаОлл { get; set; }
    }
}
