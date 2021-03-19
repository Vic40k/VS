using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ПрайсОсновнойNew
    {
        public string Наименование { get; set; }
        public decimal? ЦенаСНдс { get; set; }
        public decimal? ЦенаБезНдс { get; set; }
        public decimal? КурсUsd { get; set; }
        public decimal? КурсEuro { get; set; }
        public string МетодLifo { get; set; }
        public string СНдс { get; set; }
        public decimal? Кдр { get; set; }
        public int IdИзделия { get; set; }
        public string Площадка { get; set; }
        public decimal? ЧистыйВес { get; set; }
        public decimal? Ким { get; set; }
        public decimal? Амортизация { get; set; }
        public string Статус { get; set; }
        public string ГруппаТовара { get; set; }
        public string Участок { get; set; }
        public DateTime? ДатаФормирования { get; set; }
        public string Артикул { get; set; }
        public string Кто { get; set; }
        public int? UserId { get; set; }
        public decimal? Трудозатраты { get; set; }
        public string МетодКосвенных { get; set; }
        public string Expr1 { get; set; }
        public decimal? КраскаПорошковая { get; set; }
        public decimal? КраскаЖидк { get; set; }
        public decimal? Картон { get; set; }
        public decimal? Пенопласт { get; set; }
        public decimal? Панели { get; set; }
        public decimal? Сырье { get; set; }
        public decimal? Замки { get; set; }
        public decimal? Крепеж { get; set; }
        public decimal? Комплектующие { get; set; }
        public decimal? Упаковка { get; set; }
        public decimal? Наполнители { get; set; }
        public decimal? ЗпПрямая { get; set; }
        public decimal? ЗпНалоги { get; set; }
        public decimal? НормИт { get; set; }
        public short ТипРасчета { get; set; }
        public decimal? ВесИт { get; set; }
        public decimal? Материалы { get; set; }
        public decimal? МатериалыUsd { get; set; }
        public decimal? МатериалыEuro { get; set; }
        public decimal? КомплектующиеИмп { get; set; }
        public decimal? Ит { get; set; }
    }
}
