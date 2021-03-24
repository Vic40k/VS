﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class TPrice
    {
        public int Id { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public decimal? СсЗмк { get; set; }
        public decimal? СсУзмк { get; set; }
        public decimal? ЦпСосенки { get; set; }
        public decimal? ЦпУзмк { get; set; }
        public decimal? FobЗмк { get; set; }
        public decimal? FobУзмк { get; set; }
    }
}