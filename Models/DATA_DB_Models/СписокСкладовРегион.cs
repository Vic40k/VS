using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокСкладовРегион
    {
        public int IdСклада { get; set; }
        public string Наименование { get; set; }
        public int IdГорода { get; set; }
        public int Регион { get; set; }
        public string НомерДоговора { get; set; }
        public bool? Deleted { get; set; }
        public int? IdЮрлица { get; set; }
        public int ЦенаИзДоговора { get; set; }
        public string ГрузополучательСклада { get; set; }
        public int ЗаводСклад { get; set; }
        public int RecSkl { get; set; }
        public string АдресСклада { get; set; }
    }
}
