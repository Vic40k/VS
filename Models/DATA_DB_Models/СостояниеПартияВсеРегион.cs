using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СостояниеПартияВсеРегион
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public int Партия { get; set; }
        public double? Кол { get; set; }
        public decimal? Seb { get; set; }
        public decimal? SebR { get; set; }
        public string НомерГтд { get; set; }
        public decimal? Цена { get; set; }
        public int Регион { get; set; }
    }
}
