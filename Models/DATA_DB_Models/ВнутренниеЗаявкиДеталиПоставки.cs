using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВнутренниеЗаявкиДеталиПоставки
    {
        public int Nbr { get; set; }
        public int Id { get; set; }
        public int? IdТовара { get; set; }
        public decimal Количество { get; set; }
        public decimal? Price { get; set; }
        public decimal? Summa { get; set; }
        public int FactoryId { get; set; }
        public int Статус { get; set; }
        public string НомерЗаявки { get; set; }
        public string Description { get; set; }

        public virtual ВнутренниеЗаявкиПоставки ВнутренниеЗаявкиПоставки { get; set; }
    }
}
