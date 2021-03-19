using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПодгруппПод
    {
        public int IdПод { get; set; }
        public string Под { get; set; }
        public int Категория { get; set; }
        public int? Контролировать { get; set; }
    }
}
