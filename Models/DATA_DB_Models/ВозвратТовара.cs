using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВозвратТовара
    {
        public string Название { get; set; }
        public int Счет { get; set; }
        public DateTime Дата { get; set; }
        public int? Накладная { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public string Товар { get; set; }
        public decimal? Колво { get; set; }
        public int IdДилера { get; set; }
        public DateTime? ДатаВозврата { get; set; }
        public int RecordId { get; set; }
        public int IdТовара { get; set; }
    }
}
