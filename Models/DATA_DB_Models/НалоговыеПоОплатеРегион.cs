﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НалоговыеПоОплатеРегион
    {
        public int НомерПокупателя { get; set; }
        public string Наименование { get; set; }
        public int IdФирмы { get; set; }
        public bool ВидОплаты { get; set; }
        public byte UsdRu { get; set; }
        public string Год { get; set; }
        public int НомерПорядковый { get; set; }
        public int Регион { get; set; }
        public DateTime Дата { get; set; }
    }
}
