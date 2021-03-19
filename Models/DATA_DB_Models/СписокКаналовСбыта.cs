using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКаналовСбыта
    {
        public int IdКаналаСбыта { get; set; }
        public string КаналСбыта { get; set; }
        public int? КодСортировки { get; set; }
        public string Кратко { get; set; }
    }
}
