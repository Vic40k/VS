﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПоЗаявкамДляДолгаРегионДвери
    {
        public int Номер { get; set; }
        public double? СуммаR { get; set; }
        public int Регион { get; set; }
        public double? СуммаВСчете { get; set; }
        public decimal? СуммаБезНдс { get; set; }
        public decimal? Ндс { get; set; }
        public decimal? СуммаСчетаДоСкидки { get; set; }
        public int? KlientRegSvoj { get; set; }
    }
}
