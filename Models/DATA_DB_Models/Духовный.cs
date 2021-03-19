using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Духовный
    {
        public string Наименование { get; set; }
        public string Название { get; set; }
        public string LastФамилия { get; set; }
        public string Expr1 { get; set; }
        public decimal? SumСуммаОплаты { get; set; }
        public decimal? SumСуммаОплатыR { get; set; }
    }
}
