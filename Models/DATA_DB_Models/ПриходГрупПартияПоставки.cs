using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходГрупПартияПоставки
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public int Партия { get; set; }
        public decimal? Приход { get; set; }
        public decimal? Seb { get; set; }
        public decimal? SebR { get; set; }
        public string НомерГтд1 { get; set; }
        public string Валюта { get; set; }
        public string ЕдИзм { get; set; }
        public int? Поставщик { get; set; }
        public int FactoryId { get; set; }
    }
}
