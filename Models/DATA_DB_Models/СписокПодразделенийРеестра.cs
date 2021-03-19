using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПодразделенийРеестра
    {
        public int IdПодразделения { get; set; }
        public string Наименование { get; set; }
        public short? Знак { get; set; }
    }
}
