using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВозвратыПоставкиТолькоУзмк
    {
        public DateTime? ДатаОприходования { get; set; }
        public decimal? СуммаОтгр { get; set; }
        public string Наименование { get; set; }
        public string Выражение1 { get; set; }
        public string Документ { get; set; }
        public int IdЮрлица { get; set; }
        public int Expr2 { get; set; }
        public int IdДилера { get; set; }
        public decimal? IdФирмы { get; set; }
    }
}
