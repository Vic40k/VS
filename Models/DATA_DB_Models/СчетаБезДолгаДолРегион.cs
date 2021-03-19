﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СчетаБезДолгаДолРегион
    {
        public int Номер { get; set; }
        public int Регион { get; set; }
        public decimal? СуммаВСчете { get; set; }
    }
}
