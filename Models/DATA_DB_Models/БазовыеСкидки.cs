using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class БазовыеСкидки
    {
        public int RecordId { get; set; }
        public int? IdГруппы { get; set; }
        public short? Скидка { get; set; }
        public short? Скидка10 { get; set; }
        public short? Скидка5 { get; set; }
        public short? Скидка51 { get; set; }
    }
}
