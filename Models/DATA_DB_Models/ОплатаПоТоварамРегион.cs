using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОплатаПоТоварамРегион
    {
        public int? RecordIdОплата { get; set; }
        public int? RecordIdРасход { get; set; }
        public decimal? КоличествоОплаченное { get; set; }
        public int RecordId { get; set; }
        public int? Регион { get; set; }
        public int? RecordIdОплатаOld { get; set; }
        public int? RecordIdРасходOld { get; set; }
    }
}
