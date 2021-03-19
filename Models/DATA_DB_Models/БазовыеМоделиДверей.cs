using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class БазовыеМоделиДверей
    {
        public int IdБазы { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string ШифрСборки { get; set; }
        public string IdКонструкции { get; set; }
        public string КодШирины { get; set; }
        public string КодВысоты { get; set; }
        public string КодОткрывания { get; set; }
        public decimal? ПлощадьМ2 { get; set; }
        public decimal? Цена { get; set; }
        public decimal? ЦенаТрудозатрат { get; set; }
        public decimal? ЧасыТрудозатрат { get; set; }
    }
}
