using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсАмортизацияСтроки
    {
        public int Id { get; set; }
        public int IdTmc { get; set; }
        public int PeriodId { get; set; }
        public byte TypeId { get; set; }
        public decimal SummaOst { get; set; }
        public decimal Summa { get; set; }
        public string AccountDb { get; set; }
        public string AnalitDb { get; set; }
        public string AccountCr { get; set; }
        public string AnalitCr { get; set; }
    }
}
