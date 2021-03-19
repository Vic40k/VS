﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокБалловПоСмпр
    {
        public decimal СмпрОт { get; set; }
        public decimal СмпрДо { get; set; }
        public int ГруппаСкидки { get; set; }
        public int НомерСтроки { get; set; }
        public int? Ось { get; set; }
    }
}
