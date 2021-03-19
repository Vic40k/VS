using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СпецценыДляСебестоимости
    {
        public int? IdТовара { get; set; }
        public decimal? Цена { get; set; }
        public int? Валюта { get; set; }
        public string ЕдИзм { get; set; }
        public int Id { get; set; }
        public int? Ндс { get; set; }
        public int IdПлощадки { get; set; }
    }
}
