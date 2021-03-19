using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЦветов
    {
        public int IdЦвета { get; set; }
        public string Цвет { get; set; }
        public int? IdПоставщика { get; set; }
    }
}
