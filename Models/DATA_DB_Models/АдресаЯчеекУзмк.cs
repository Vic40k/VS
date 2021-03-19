using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class АдресаЯчеекУзмк
    {
        public int RecordId { get; set; }
        public string Адрес { get; set; }
        public string ШтрихКод { get; set; }
        public int? Склад { get; set; }
        public int? Регион { get; set; }
    }
}
