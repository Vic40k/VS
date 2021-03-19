using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходГрупПартияДляСфПоставки
    {
        public int IdТовара { get; set; }
        public int Партия { get; set; }
        public decimal? ЦенаРуб { get; set; }
        public int FactoryId { get; set; }
    }
}
