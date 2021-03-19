﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходГруп965
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public int Заявка { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public int Регион { get; set; }
        public decimal? Количество { get; set; }
    }
}
