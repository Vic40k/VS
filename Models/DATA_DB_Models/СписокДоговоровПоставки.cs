using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДоговоровПоставки
    {
        public int FactoryId { get; set; }
        public int IdДоговора { get; set; }
        public int IdЮрлица { get; set; }
        public string Договор { get; set; }
        public DateTime? ДатаДоговора { get; set; }
        public DateTime? ДатаНачала { get; set; }
        public DateTime? ДатаОкончания { get; set; }
        public int? УсловияОплаты { get; set; }
        public int? УсловияПоставки { get; set; }
        public int? МетодПоставки { get; set; }
        public int? IdВалюты { get; set; }
    }
}
