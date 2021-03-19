using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЛюдиГрейд
    {
        public int Hid { get; set; }
        public string Fio { get; set; }
        public string Dbeg { get; set; }
        public int DolId { get; set; }
        public string Name { get; set; }
        public int? Grade { get; set; }
        public int? PrNodeId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? MinPoint { get; set; }
        public int? MaxPoint { get; set; }
    }
}
