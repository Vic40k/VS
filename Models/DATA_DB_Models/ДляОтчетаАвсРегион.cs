﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДляОтчетаАвсРегион
    {
        public string Abc { get; set; }
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public decimal? Сс { get; set; }
        public decimal? Кол { get; set; }
        public string Артикул { get; set; }
        public int UserId { get; set; }
        public string КодТовара { get; set; }
        public int IdТовара { get; set; }
    }
}
