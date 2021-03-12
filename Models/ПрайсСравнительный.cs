using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ПрайсСравнительный
    {
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public decimal? Трудозатраты { get; set; }
        public decimal? ЧистыйВес { get; set; }
        public decimal? ЦенаСНдс { get; set; }
        public decimal? ЦенаБезНдс { get; set; }
        public decimal? ЦенаСНдсСрав { get; set; }
        public decimal? ЦенаБезНдсСрав { get; set; }
        public decimal? ИзмЦСНдс { get; set; }
        public decimal? ИзмЦБезНдс { get; set; }
        public string Статус { get; set; }
        public string ГруппаТовара { get; set; }
        public string Участок { get; set; }
        public DateTime? ДатаФормирования { get; set; }
        public DateTime? ДатаФормированияСрав { get; set; }
        public decimal? КурсUsd { get; set; }
        public decimal? КурсEuro { get; set; }
        public string МетодLifo { get; set; }
        public string СНдс { get; set; }
        public string Площадка { get; set; }
        public decimal? КурсUsdСрав { get; set; }
        public decimal? КурсEuroСрав { get; set; }
        public string МетодLifoСрав { get; set; }
        public string МетодКосСрав { get; set; }
        public string МетодКос { get; set; }
        public string ПлощадкаСрав { get; set; }
        public string СНдсСрав { get; set; }
        public string Кто { get; set; }
        public int? UserId { get; set; }
        public int? Номер { get; set; }
        public string Согласовал1 { get; set; }
        public string Согласовал2 { get; set; }
        public string Согласовал3 { get; set; }
        public string Согласовал4 { get; set; }
    }
}
