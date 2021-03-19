using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТзОтгрузкаПодгруппы
    {
        public int? IdПодгруппы { get; set; }
        public string ПодГруппа { get; set; }
        public decimal? Количество { get; set; }
        public decimal? СуммаРуб { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? Себестоимость { get; set; }
        public decimal? СебестоимостьРуб { get; set; }
        public int? UserId { get; set; }
        public decimal? СуммаБезНдсРуб { get; set; }
        public decimal? СебестоимостьБезНдсРуб { get; set; }
        public int? Неделя { get; set; }
        public int? Рег { get; set; }
        public int? Тула { get; set; }
        public int? Сосенки { get; set; }
        public string Участок { get; set; }
        public string Завод { get; set; }
        public decimal? СуммаEuro { get; set; }
        public decimal? СебестоимостьEuro { get; set; }
        public decimal? СуммаБезНдсEuro { get; set; }
        public decimal? СебестоимостьБезНдсEuro { get; set; }
        public decimal? СуммаРц { get; set; }
    }
}
