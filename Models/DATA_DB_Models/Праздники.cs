using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Праздники
    {
        public byte? День { get; set; }
        public byte? Месяц { get; set; }
        public string Название { get; set; }
        public int RecordId { get; set; }
        public DateTime? Дата { get; set; }
    }
}
