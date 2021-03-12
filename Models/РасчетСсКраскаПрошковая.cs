using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class РасчетСсКраскаПрошковая
    {
        public int IdИзделия { get; set; }
        public DateTime ДатаФормирования { get; set; }
        public byte? Площадка { get; set; }
        public decimal? КраскаПорошковая { get; set; }
        public short ТипРасчета { get; set; }
        public decimal? КраскаЖидкая { get; set; }
        public decimal? Картон { get; set; }
        public decimal? Пенопласт { get; set; }
        public decimal? Панели { get; set; }
        public decimal? Сырье { get; set; }
        public decimal? Замки { get; set; }
        public decimal? Краска { get; set; }
        public decimal? Крепеж { get; set; }
        public decimal? Комплектующие { get; set; }
        public decimal? КомплектующиеИмп { get; set; }
        public decimal? Упаковка { get; set; }
        public decimal? Наполнители { get; set; }
        public decimal? ЗпПрямая { get; set; }
        public decimal? ЗпНалоги { get; set; }
        public decimal? Материалы { get; set; }
        public decimal? МатериалыUsd { get; set; }
        public decimal? МатериалыEuro { get; set; }
        public decimal? Ит { get; set; }
    }
}
