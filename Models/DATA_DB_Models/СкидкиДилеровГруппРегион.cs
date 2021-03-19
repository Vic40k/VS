using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СкидкиДилеровГруппРегион
    {
        public int? IdДилера { get; set; }
        public int IdТовара { get; set; }
        public decimal? Группа { get; set; }
        public decimal? Подгруппа { get; set; }
        public double? Модель { get; set; }
        public int Регион { get; set; }
    }
}
