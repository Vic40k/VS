using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокУчастков
    {
        public int IdУчастка { get; set; }
        public string КодУчастка { get; set; }
        public string Участок { get; set; }
        public int? Ответственный { get; set; }
        public int FactoryId { get; set; }
        public int? Deleted { get; set; }
    }
}
