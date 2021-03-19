using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class Заголовки
    {
        public DateTime ДатаФормирования { get; set; }
        public decimal? КурсUsd { get; set; }
        public decimal? КурсEuro { get; set; }
        public string Метод { get; set; }
        public string Ндс { get; set; }
        public decimal? Кдр { get; set; }
        public string Завод { get; set; }
        public byte? Площадка { get; set; }
    }
}
