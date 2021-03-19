using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Следы
    {
        public string Форма { get; set; }
        public int? Филиал { get; set; }
        public int? Кто { get; set; }
        public DateTime? Когда { get; set; }
    }
}
