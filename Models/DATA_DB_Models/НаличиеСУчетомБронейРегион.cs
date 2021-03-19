using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НаличиеСУчетомБронейРегион
    {
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public int Регион { get; set; }
        public decimal? Наличие { get; set; }
        public decimal? ВПути { get; set; }
        public decimal? SumOfКоличество { get; set; }
        public decimal? Expr1 { get; set; }
        public decimal? Expr2 { get; set; }
    }
}
