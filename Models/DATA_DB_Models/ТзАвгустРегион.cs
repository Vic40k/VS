﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТзАвгустРегион
    {
        public decimal? ТзСс { get; set; }
        public decimal? ТзОц { get; set; }
        public decimal? ТзСсRub { get; set; }
        public decimal? ТзОцРуб { get; set; }
        public int UserId { get; set; }
        public int Регион { get; set; }
        public int Rec { get; set; }
    }
}
