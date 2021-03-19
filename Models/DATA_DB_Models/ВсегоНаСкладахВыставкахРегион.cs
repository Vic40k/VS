using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВсегоНаСкладахВыставкахРегион
    {
        public string Наименование { get; set; }
        public decimal? Expr1 { get; set; }
        public int Vputi { get; set; }
        public decimal PriceMin { get; set; }
        public decimal Ssr { get; set; }
        public decimal Sebestoimost { get; set; }
        public int Скидка { get; set; }
        public int Регион { get; set; }
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public decimal SsrБезНдс { get; set; }
        public decimal? БазоваяЦенаR { get; set; }
        public decimal Nds { get; set; }
        public int? IdЮрлица { get; set; }
    }
}
