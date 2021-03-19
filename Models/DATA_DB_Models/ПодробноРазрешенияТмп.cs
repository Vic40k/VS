using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПодробноРазрешенияТмп
    {
        public int IdТовара { get; set; }
        public int? БезРазрешения { get; set; }
        public int? Разрешение { get; set; }
        public int? Накладная { get; set; }
        public int Регион { get; set; }
        public int Userid { get; set; }
        public int? НомерЗаказа { get; set; }
        public int? РегионЗаказа { get; set; }
        public int? IdСклада { get; set; }
        public int RecordId { get; set; }
        public int? РазрешениеНеделя { get; set; }
        public DateTime? ДатаПоследняяОчереди { get; set; }
    }
}
