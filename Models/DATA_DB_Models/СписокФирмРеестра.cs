using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокФирмРеестра
    {
        public int IdФирмы { get; set; }
        public string Наименование { get; set; }
        public short? Znak { get; set; }
        public bool Usd { get; set; }
        public short? Статус { get; set; }
        public bool Актуальна { get; set; }
        public int? Группа { get; set; }
        public int? Ответственный { get; set; }
        public string Категория { get; set; }
        public int Cash { get; set; }
        public int? IdСтраны { get; set; }
        public int CashСамыйПервый { get; set; }
        public int CashНал { get; set; }
        public int CashСамыйПервыйСохранить { get; set; }
    }
}
