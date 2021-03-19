using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class LogUsers
    {
        public string Кто { get; set; }
        public int Что { get; set; }
        public DateTime? Когда { get; set; }
        public int? Пар1 { get; set; }
    }
}
