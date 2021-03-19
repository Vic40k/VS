using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходГрупПартияРегион
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public decimal? Приход { get; set; }
        public int Партия { get; set; }
        public decimal? Seb { get; set; }
        public decimal? SebR { get; set; }
        public string НомерГтд1 { get; set; }
        public decimal? Выражение1 { get; set; }
        public int Регион { get; set; }
    }
}
