using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗамковПоМоделям
    {
        public string IdЗамка { get; set; }
        public string Замок { get; set; }
        public string Перв { get; set; }
        public int L1 { get; set; }
        public int L2 { get; set; }
        public string L3 { get; set; }
    }
}
