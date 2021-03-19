using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокИсполненийПоЗамкам
    {
        public string IdИсполненения { get; set; }
        public string Исполнение { get; set; }
        public string Перв { get; set; }
        public int L1 { get; set; }
        public int L2 { get; set; }
        public string L3 { get; set; }
        public string L4 { get; set; }
        public int? Двери { get; set; }
    }
}
