using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокУсловийОплаты
    {
        public int IdУсловия { get; set; }
        public int? Отсрочка { get; set; }
        public string УсловиеОплаты { get; set; }
        public string УсловиеОплатыEn { get; set; }
    }
}
