using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ПрасСравнение
    {
        public decimal? ЦенаСНдс { get; set; }
        public decimal? ЦенаБезНдс { get; set; }
        public decimal? КурсUsd { get; set; }
        public decimal? КурсEuro { get; set; }
        public string МетодLifo { get; set; }
        public string СНдс { get; set; }
        public decimal? Кдр { get; set; }
        public int IdИзделия { get; set; }
        public string Площадка { get; set; }
        public DateTime? ДатаФормирования { get; set; }
        public int? UserId { get; set; }
        public string МетодКосвенных { get; set; }
    }
}
