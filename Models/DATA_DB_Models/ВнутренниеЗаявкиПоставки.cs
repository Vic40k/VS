using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВнутренниеЗаявкиПоставки
    {
        public ВнутренниеЗаявкиПоставки()
        {
            ВнутренниеЗаявкиДеталиПоставки = new HashSet<ВнутренниеЗаявкиДеталиПоставки>();
        }

        public int Id { get; set; }
        public int IdУчастка { get; set; }
        public int IdРаботника { get; set; }
        public DateTime Дата { get; set; }
        public int Статус { get; set; }
        public string Пояснение { get; set; }
        public int FactoryId { get; set; }
        public int UserId { get; set; }
        public bool Утверждено { get; set; }
        public decimal Total { get; set; }
        public int? ConfirmBy { get; set; }

        public virtual ICollection<ВнутренниеЗаявкиДеталиПоставки> ВнутренниеЗаявкиДеталиПоставки { get; set; }
    }
}
