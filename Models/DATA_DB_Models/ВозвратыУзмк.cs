using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВозвратыУзмк
    {
        public decimal Количество { get; set; }
        public DateTime ДатаПрихода { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public decimal Expr1 { get; set; }
        public int НомерПокупателя { get; set; }
        public string Накладная { get; set; }
        public int IdДилера { get; set; }
        public int IdЮрлица { get; set; }
        public int UsdRu { get; set; }
        public string НомерНакл { get; set; }
        public int RecordId { get; set; }
        public string Наименование { get; set; }
        public decimal? Nds { get; set; }
    }
}
