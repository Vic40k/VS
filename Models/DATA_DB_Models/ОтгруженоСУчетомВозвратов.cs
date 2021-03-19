﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгруженоСУчетомВозвратов
    {
        public int IdТовара { get; set; }
        public byte ДилерКлиент { get; set; }
        public int НомерПокупателя { get; set; }
        public double? Expr1 { get; set; }
    }
}
