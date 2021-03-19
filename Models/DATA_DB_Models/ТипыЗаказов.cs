using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТипыЗаказов
    {
        public int КодТипа { get; set; }
        public string ТипЗаказа { get; set; }
        public short IdПоставщика { get; set; }
    }
}
