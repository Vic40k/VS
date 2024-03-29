﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class МатериалыLifo
    {
        public int IdТовара { get; set; }
        public int IdСтатьиЗатрат { get; set; }
        public string Наименование { get; set; }
        public string EdIzm { get; set; }
        public decimal? ЦенаРуб { get; set; }
        public string АртикулНовый { get; set; }
        public int GroupOfGoods { get; set; }
        public int ТипГруппы { get; set; }
    }
}
