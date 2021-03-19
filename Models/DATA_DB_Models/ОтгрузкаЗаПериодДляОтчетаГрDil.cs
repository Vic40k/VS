﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгрузкаЗаПериодДляОтчетаГрDil
    {
        public int IdДилера { get; set; }
        public decimal? Отгрузка { get; set; }
        public int UserId { get; set; }
        public int? Dil { get; set; }
        public decimal? ОтгрЦр { get; set; }
    }
}
