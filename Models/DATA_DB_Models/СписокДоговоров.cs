using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДоговоров
    {
        public int IdДоговора { get; set; }
        public int IdЮрлица { get; set; }
        public string Договор { get; set; }
        public bool? Действующий { get; set; }
        public bool Выставка { get; set; }
        public bool? Пролонгация { get; set; }
        public DateTime? ДатаНачала { get; set; }
        public DateTime? ДатаОкончания { get; set; }
        public int FactoryId { get; set; }
        public int? Регион { get; set; }
    }
}
