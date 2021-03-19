using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PriceПоставки
    {
        public int RecordId { get; set; }
        public int SafeId { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceSpec { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? Sebestoimost { get; set; }
        public decimal? ЦенаFob { get; set; }
        public decimal? Ssr { get; set; }
        public string Валюта { get; set; }
        public DateTime? ДатаПартии { get; set; }
        public decimal ЦенаБезНдс { get; set; }
        public decimal? ЦенаБезНдсНаПромет { get; set; }
        public decimal? ЦенаСНдсПромет { get; set; }
        public decimal? ЦенаБезНдсНаСейф { get; set; }
        public decimal? ЦенаСНдсСейф { get; set; }
        public int FactoryId { get; set; }
    }
}
