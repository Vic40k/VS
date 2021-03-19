using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НомерПрефиксПереноскаРегион
    {
        public int НомерПокупателя { get; set; }
        public short? Префикс { get; set; }
        public string Накладная { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public bool Перенесен { get; set; }
        public int? Регион { get; set; }
    }
}
